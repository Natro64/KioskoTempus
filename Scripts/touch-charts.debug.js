/*!
* Data Aquarium Framework - Charts for Touch UI
* Copyright 2008-2015 Code On Time LLC; Licensed MIT; http://codeontime.com/license
*/
(function () {

    var $window = $(window),
        $mobile = $.mobile,
        touch = $app.touch,
        loadedPackages = {},
        resources = Web.DataViewResources.Presenters.Charts,
        resourcesMobile = Web.DataViewResources.Mobile,
        apiLoaded;

    function isPieChart(chartType) {
        return chartType.match(/pie|donut/i);
    }

    // loads a package and calls back when ready
    function loadPackage(packages, callback, module, version) {
        if (!module)
            module = 'visualization';
        if (!version)
            version = '1';
        var key = module + version + (typeof packages == 'string' ? packages : packages.join('-')),
            packageInfo = loadedPackages[key];
        if (packageInfo && packageInfo.loaded)
            callback();
        else {
            if (packageInfo && !packageInfo.loaded)
                packageInfo.callbacks.push(callback);
            else {
                $app.touch.busyIndicator(true);
                packageInfo = loadedPackages[key] = { loaded: false, callbacks: [callback] };
                google.load(module, version, {
                    packages: packages, callback: function () {
                        $app.touch.busyIndicator(false);
                        packageInfo.loaded = true;
                        $(packageInfo.callbacks).each(function () {
                            this();
                        });
                    }
                });
            }
        }
    }

    // draw a table of data and a mini chart
    function drawData(pivot, placeholder) {
        var headerRow = $('<div class="app-chart-headerbar"></div>').appendTo(placeholder),
            miniChart = $('<div class="app-chart-mini"></div>').appendTo(headerRow).attr('title', resources.ShowChart),
            titleText = pivot.Properties["title"] || pivot.Title,
            title = $('<span class="app-chart-header"></span>').appendTo(headerRow),
            data = $('<div class="app-chart-data app-scrollable"></div>').appendTo(placeholder),
            table = $('<table></table>').appendTo(data),
            isHeaderRow = true,
            showMiniChart = !pivot.ChartType.match(/map|table/);
        if (!showMiniChart)
            miniChart.hide();
        placeholder.closest('.app-chart').addClass('app-chart-has-data');
        pivot.ShowData = true;

        loadPackage('corechart', function () {
            var dataTable = google.visualization.arrayToDataTable(pivot.ChartData),
                rows = dataTable.getNumberOfRows(),
                cols = dataTable.getNumberOfColumns(),
                rowElem = $('<tr></tr>').appendTo(table),
                row,
                col,
                data,
                cell;
            title.text(titleText.substring(0, 1).toUpperCase() + titleText.substring(1));
            applyFormat(pivot, dataTable);
            // render header
            for (col = 0; col < cols; col++) {
                data = dataTable.getColumnLabel(col); //pivot.Data[0][col];
                cell = $('<th></th>').appendTo(rowElem);
                if (data != null)
                    cell.text(data).attr('title', data);
            }

            // render data
            for (row = 0; row < rows; row++) {
                rowElem = $('<tr></tr>').appendTo(table);
                for (col = 0; col < cols; col++) {
                    data = dataTable.getFormattedValue(row, col),
                    cell = $('<td></td>').appendTo(rowElem);
                    if (data != null)
                        cell.text(data == "0" ? '' : data).attr('title', data);
                }
            }
            if (showMiniChart)
                drawChart(pivot, miniChart);
        });

        // calculate data size
        data.height(Math.floor(placeholder.height() - headerRow.outerHeight(true)));
        data.width(placeholder.width());
    }

    // draw chart in the placeholder
    function drawChart(pivot, placeholder) {
        var visualization = visualizations[pivot.ChartType];
        if (visualization)
            visualization(pivot, placeholder);
    }

    // initialize default options
    function chartOptions(pivot, selector, options) {
        var isPie = isPieChart(pivot.ChartType),
            titleText = pivot.Properties["title"] || pivot.Title;
        if (!options)
            options = {};
        if (!options.legend)
            options.legend = {};
        if (!options.hAxis)
            options.hAxis = {};
        if (!options.vAxis)
            options.vAxis = {};
        if (!options.chartArea)
            options.chartArea = {};
        if (!options.tooltip)
            options.tooltip = {};
        // place background colors here
        options.title = titleText.charAt(0).toUpperCase() + titleText.slice(1);
        options.width = Math.floor(selector.width()) - 1;
        options.height = Math.floor(selector.height()) - 1;
        options.tooltip.trigger = 'focus';
        // hide legend if only one column
        if (pivot.ChartData[0].length <= 2) {
            if (!isPie)
                options.legend.position = 'none';
            if (isPie)
                pivot.Properties["maximize"] = true;
        }
        if (isPie)
            options.sliceVisibilityThreshold = 0;
        // custom properties
        for (var property in pivot.Properties) {
            if (pivot.Properties.hasOwnProperty(property)) {
                var value = pivot.Properties[property];
                switch (property) {
                    case "crosshair":
                        options["crosshair"] = {
                            orientation: value == 0 ? "both" : value,
                            trigger: 'both'
                        };
                        break;
                    case "maximize":
                        if (!isPie) {
                            options.titlePosition = 'in';
                            options.chartArea.width = '100%'; // 90%
                            options.chartArea.height = '100%'; // 90%
                            if (!options.legend.position)
                                options.legend.position = 'in';
                        }
                        else {
                            options.chartArea.top = '15%';
                            options.chartArea.width = '80%';
                            options.chartArea.height = '80%';
                        }
                        options.axisTitlesPosition = 'in';
                        options.hAxis.textPosition = 'in';
                        options.vAxis.textPosition = 'in';
                        break;
                    case "haxistitle":
                        options.hAxis.title = value;
                        break;
                    case "vaxistitle":
                        options.vAxis.title = value;
                        break;
                        // geo chart properties           
                    case "region":
                        options.region = value;
                        break;
                    case "displaymode":
                        options.displayMode = value;
                        break;
                    case "resolution":
                        options.resolution = value;
                        break;
                        // line chart properties           
                    case "curve":
                        options.curveType = "function";
                        break;
                    case "explorer":
                        options.explorer = {};
                        break;
                        // map chart properties           
                    case "maptype":
                        options.mapType = value;
                        break;
                    case "enablescrollwheel":
                        options.enableScrollWheel = true;
                        break;
                    case "usemaptypecontrol":
                        options.useMapTypeControl = true;
                        break;
                        // misc           
                    case "pointshape":
                        options.pointShape = value;
                        break;
                    case "pointsize":
                        options.pointSize = value;
                        break;
                    case "orientation":
                        options.orientation = value;
                        break;
                    case "animation":
                        options.animation = { startup: true, duration: 500, easing: 'out' };
                        break;
                    case "colors":
                        var colors = value.split(',');
                        for (var i in colors)
                            colors[i] = colors[i].trim();
                        options.colors = colors;
                        break;
                }
            }
        }
        if (pivot.ShowData) {
            options.legend.position = 'none';
            options.axisTitlesPosition = 'none';
            options.height = '100%';
            options.titlePosition = 'none';
            options.chartArea.top = '0';
            options.chartArea.width = '100%';
            options.chartArea.height = '100%';
            options.enableInteractivity = false;
        }
        //if (pivot.ChartType == 'geo')
        //  options.backgroundColor = '#fff';
        if ($('body').hasClass('app-theme-dark')) {
            options.backgroundColor = '#1f1f1f';
            options.hAxis.textStyle = { color: 'white' };
            options.hAxis.gridlines = { color: '#000' };
            options.vAxis.textStyle = { color: 'white' };
            options.vAxis.gridlines = { color: '#000' };
            options.legend.textStyle = { color: '#999' };
            options.legend.scrollArrows = { activeColor: '#fff', inactiveColor: '#777' };
            options.legend.pagingTextStyle = { color: '#999' };
            options.titleTextStyle = { color: 'white' };
            if (isPie)
                options.pieSliceBorderColor = '#111';

        }
        return options;
    }

    // apply format strings specified in the pivot.Formats property
    function applyFormat(pivot, dataTable) {
        var valueFieldCount = pivot.ValueFieldNames.length,
            columnFieldCount = pivot.ValueFieldNames.length;
        for (name in pivot.Formats) {
            var format = pivot.Formats[name],
                matches = /(\w+)(\d)/.exec(name),
                fieldName = matches[1],
                fieldIndex = matches[2],
                columnIndex = pivot.ValueFieldNames.indexOf(fieldName, fieldIndex),
                formatter;
            if (columnIndex == -1 || !format)
                continue;

            switch (format.toLowerCase()) {
                case "c":
                case "C":
                    format = "\u00A400.00";
                    break;
                case "d":
                case "D":
                    format = "00.00";
                    break;
                case "e":
                case "E":
                    format = "0.######E+000";
                    break;
                case "f":
                case "F":
                    format = "00.00";
                    break;
                case "n":
                case "N":
                    format = "00.00";
                    break;
                case "p":
                case "P":
                    format = "%";
                    break;
                case "x":
                case "X":
                    format = "00.00";
                    break;
            }

            // specifies ICU decimal format http://icu-project.org/apiref/icu4c/classDecimalFormat.html#_details
            // TODO check for type
            formatter = new google.visualization.NumberFormat({ pattern: format });

            for (var i = columnIndex + 1; i < pivot.Data[0].length; i = i + valueFieldCount) {
                formatter.format(dataTable, i);
            }
        }
    }

    // initialize event handlers and draw the chart
    function draw(pivot, selector, chart, options) {
        var data = google.visualization.arrayToDataTable(pivot.ChartData),
            isGeo = pivot.ChartType.match(/geo/i);

        function attachSelectAction() {
            //chart.setAction({
            //    id: 'filter',
            //    text: resourcesMobile.Filter,
            //    action: function () {
            //        var selection = chart.getSelection(),
            //            col, row,
            //            values = [];
            //        if (selection) {
            //            selection = selection[0]
            //            if (selection.column) {
            //                col = selection.column;
            //            }
            //            else {
            //                row = selection.row + 1;
            //                values.push(pivot.ChartData[row][0]);
            //                $(pivot.ChartData).each(function (index) {
            //                    if (index > 0 && index != row)
            //                        values.push(this[0]);
            //                });
            //                touch.configureFilter({ mode: 'field', field: pivot.RowFieldNames[0], scope: null, values: values });
            //            }
            //        }
            //    }
            //});
        }

        // format 
        applyFormat(pivot, data);

        if (!touch.desktop() && !isGeo)
            attachSelectAction();
        if (pivot.Properties["animation"] && !isGeo && pivot.ChartType != 'map')
            chart.draw(null, options);
        chart.draw(data, options);

        if (touch.desktop() && !isGeo) {
            google.visualization.events.addListener(chart, 'select', function () {
                if (options.tooltip.trigger == 'focus') {
                    options.tooltip.trigger = 'selection';
                    var selection = chart.getSelection();
                    attachSelectAction();
                    chart.draw(data, options);
                    chart.setSelection(selection);
                    return false;
                }
            });
            google.visualization.events.addListener(chart, 'click', function (event) {
                if (!event.targetID.match(/^action/) && options.tooltip.trigger == 'selection') {
                    options.tooltip.trigger = 'focus';
                    chart.removeAction('filter');
                    chart.removeAction('exclude');
                    chart.setSelection(null);
                    chart.draw(data, options);
                }
            });
        }
    }


    $(document).on('resizing.app searching.app', function () {
        $.mobile.activePage.find('.app-chart-inner').children().hide();
    })

        .on('vclick', '.app-chart', function (event) {

            function showChart() {
                delete config.ShowData;
                dataView.viewProp('chartsConfig', chartsConfig);

                var pivot = target.closest('.app-chart-list').parent().data('pivots')["pivot" + pivotID],
                    inner = target.closest('.app-chart').find('.app-chart-inner');
                inner.empty();

                // reset state 
                inner.closest('.app-chart').removeClass('app-chart-has-data');
                pivot.ShowData = false;

                drawChart(pivot, inner);
            }

            var target = $(event.target);
            var echo = target.closest('.app-echo'),
                dataView = echo.length ? $app.find(echo.attr('data-for')) : touch.dataView(),
                dataContext = target.closest('.app-chart').data('data-context');
            if (!dataView || !dataContext)
                return;

            var pivotID = dataContext.Id,
                chartsConfig = dataView.viewProp('chartsConfig'),
                config = chartsConfig && chartsConfig[pivotID],
                isSidebar = !$('body').hasClass('app-sidebar-undocked'),
                windowWidthEm = $(window).width() / parseFloat($("body").css("font-size")),
                med = (isSidebar && windowWidthEm >= 50) || (!isSidebar && windowWidthEm >= 40),
                large = (isSidebar && windowWidthEm >= 85) || (!isSidebar && windowWidthEm >= 62),
                currentSize = config.size ? config.size : 'small',
                items = [];

            if (target.is('.app-btn-more') && !$app.mobile.busy()) {
                $app.mobile.callWithFeedback(target.closest('.ui-btn'), function () {

                    if (currentSize == 'large' && !large)
                        currentSize = 'medium';
                    if (currentSize == 'medium' && !med)
                        currentSize = 'small';

                    // show data
                    var pivot = target.closest('.app-chart-list').parent().data('pivots')["pivot" + pivotID];
                    if (!pivot.ChartType.match(/map|table/)) {
                        if (config.ShowData)
                            items.push({
                                text: resources.ShowChart,
                                icon: 'chart',
                                callback: showChart
                            });
                        else
                            items.push({
                                text: resources.ShowData,
                                icon: 'grid',
                                callback: function () {
                                    config.ShowData = true;
                                    dataView.viewProp('chartsConfig', chartsConfig);

                                    var inner = target.closest('.app-chart').find('.app-chart-inner');
                                    inner.empty();
                                    drawData(pivot, inner);
                                }
                            });
                    }

                    if (target.closest('.app-chart-list').find('.app-chart').length > 1) {
                        // add sizing options
                        items.push({
                            text: resources.Sizes.Label
                        });
                        items.push({ // small
                            text: resources.Sizes.Small,
                            icon: currentSize == 'small' ? 'check' : '',
                            callback: function () {
                                delete config.size;
                                config.resized = true;
                                dataView.viewProp('chartsConfig', chartsConfig);
                                $app.touch.presenter('show', { name: 'Charts', id: dataView._id, container: target.closest('.app-wrapper') });
                            }
                        });
                        if (med) // medium
                            items.push({
                                text: resources.Sizes.Medium,
                                icon: currentSize == 'medium' ? 'check' : '',
                                callback: function () {
                                    config.size = 'medium';
                                    config.resized = true;
                                    dataView.viewProp('chartsConfig', chartsConfig);
                                    $app.touch.presenter('show', { name: 'Charts', id: dataView._id, container: target.closest('.app-wrapper') });
                                }
                            });
                        if (large) // large
                            items.push({
                                text: resources.Sizes.Large,
                                icon: currentSize == 'large' ? 'check' : '',
                                callback: function () {
                                    config.size = 'large';
                                    config.resized = true;
                                    dataView.viewProp('chartsConfig', chartsConfig);
                                    $app.touch.presenter('show', { name: 'Charts', id: dataView._id, container: target.closest('.app-wrapper') });
                                }
                            });
                    }
                    else
                        items.push({
                            text: resources.Sizes.Auto,
                            icon: 'check',
                            callback: function () { }
                        });

                    items.push({ text: resourcesMobile.Filter });
                    if (dataContext.ColumnFieldNames && dataContext.ColumnFieldNames.length)
                        items.push(
                            {
                                // TODO: must provide a dataView._id for "scope" when called for echo
                                text: dataView.findField(dataContext.ColumnFieldNames[0]).HeaderText,
                                icon: 'filter',
                                callback: function () {
                                    touch.configureFilter({
                                        field: dataContext.ColumnFieldNames[0], scope: dataView._id, mode: 'field'
                                    });
                                }
                            });


                    if (dataContext.RowFieldNames && dataContext.RowFieldNames.length)
                        items.push(
                            {
                                // TODO: must provide a dataView._id for "scope" when called for echo
                                text: dataView.findField(dataContext.RowFieldNames[0]).HeaderText,
                                icon: 'filter',
                                callback: function () {
                                    touch.configureFilter({
                                        field: dataContext.RowFieldNames[0], scope: dataView._id, mode: 'field'
                                    });
                                }
                            });


                    touch.listPopup({
                        anchor: target.closest('a'),
                        iconPos: 'right',
                        items: items
                    });
                });
                return false;
            }
            else if (target.closest('.app-chart-mini').length) {
                showChart();
                return false;
            }
        })

        .on('taphold', '.app-chart', function (event) {
            var target = $(event.target);
            if (target.is('td') && target.closest('.app-chart-data').length) {
                touch.listPopup({
                    anchor: target,
                    title: target.text()
                });
            }
        });

    var visualizations = {
        area: function (pivot, selector) {
            loadPackage('corechart', function () {
                var options = chartOptions(pivot, selector),
                    chart = new google.visualization.AreaChart($(selector).get(0));
                draw(pivot, selector, chart, options);
            })
        },
        areastacked: function (pivot, selector) {
            loadPackage('corechart', function () {
                var options = chartOptions(pivot, selector, { isStacked: true }),
                    chart = new google.visualization.AreaChart($(selector).get(0));
                draw(pivot, selector, chart, options);
            })
        },
        bar: function (pivot, selector) {
            loadPackage('corechart', function () {
                var options = chartOptions(pivot, selector),
                    chart = new google.visualization.BarChart($(selector).get(0));
                draw(pivot, selector, chart, options);
            });
        },
        barstacked: function (pivot, selector) {
            loadPackage('corechart', function () {
                var options = chartOptions(pivot, selector, { isStacked: true }),
                    chart = new google.visualization.BarChart($(selector).get(0));
                draw(pivot, selector, chart, options);
            });
        },
        column: function (pivot, selector) {
            loadPackage('corechart', function () {
                var options = chartOptions(pivot, selector),
                    chart = new google.visualization.ColumnChart($(selector).get(0));
                draw(pivot, selector, chart, options);
            });
        },
        columnstacked: function (pivot, selector) {
            loadPackage('corechart', function () {
                var options = chartOptions(pivot, selector, { isStacked: true }),
                    chart = new google.visualization.ColumnChart($(selector).get(0));
                draw(pivot, selector, chart, options);
            });
        },
        candlestick: function (pivot, selector) {
            loadPackage('corechart', function () {
                var options = chartOptions(pivot, selector),
                    chart = new google.visualization.CandlestickChart($(selector).get(0));
                draw(pivot, selector, chart, options);
            });
        },
        donut: function (pivot, selector) {
            loadPackage('corechart', function () {
                var options = chartOptions(pivot, selector, { pieHole: 0.4, backgroundColor: 'transparent' }),
                    chart = new google.visualization.PieChart($(selector).get(0));
                draw(pivot, selector, chart, options);
            });
        },
        geo: function (pivot, selector) {
            loadPackage('geochart', function () {
                var options = chartOptions(pivot, selector, { backgroundColor: 'transparent' }),
                    chart = new google.visualization.GeoChart($(selector).get(0));
                draw(pivot, selector, chart, options);
            });
        },
        map: function (pivot, selector) {
            loadPackage('map', function () {
                var options = chartOptions(pivot, selector, { showTip: true }),
                    chart = new google.visualization.Map($(selector).get(0));
                draw(pivot, selector, chart, options);
            });
        },
        line: function (pivot, selector) {
            loadPackage('corechart', function () {
                var options = chartOptions(pivot, selector, { showTip: true }),
                    chart = new google.visualization.LineChart($(selector).get(0));
                draw(pivot, selector, chart, options);
            });
        },
        pie: function (pivot, selector) {
            loadPackage('corechart', function () {
                var options = chartOptions(pivot, selector, { title: pivot.Title, backgroundColor: 'transparent' }),
                    chart = new google.visualization.PieChart($(selector).get(0));
                draw(pivot, selector, chart, options);
            });
        },
        pie3d: function (pivot, selector) {
            loadPackage('corechart', function () {
                var options = chartOptions(pivot, selector, {
                    backgroundColor: 'transparent',
                    is3D: true
                }),
                    chart = new google.visualization.PieChart($(selector).get(0));
                draw(pivot, selector, chart, options);
            });
        },
        scatter: function (pivot, selector) {
            loadPackage('corechart', function () {
                var options = chartOptions(pivot, selector),
                    chart = new google.visualization.ScatterChart($(selector).get(0));
                draw(pivot, selector, chart, options);
            });
        },
        table: function (pivot, selector) {
            loadPackage('table', function () {
                var options = chartOptions(pivot, selector),
                    chart = new google.visualization.Table($(selector).get(0));
                draw(pivot, selector, chart, options);
            });
        }
    };

    // presenter implementation
    $app.touch.presenter('register', {
        name: 'Charts',
        icon: function () { return 'chart' },
        text: function () { return resources.Text },
        supports: function (dataView) {
            var isSupported = false;
            $(dataView._fields).each(function () {
                if (this.Tag && this.Tag.indexOf("pivot") != -1) {
                    isSupported = true;
                    return false;
                }
            });
            //dataView.AutoPivots = null;
            // calculate auto pivots
            if (isSupported)
                dataView.AutoPivots = null;
            else {
                if (dataView.AutoPivots && $.isEmptyObject(dataView.AutoPivots))
                    return true;
                else {
                    var pivotCount = 1,
                        firstField = dataView._fields[0].Label,
                        lookups = [],
                        lookupCount = 0,
                        lookupChartCount = 0,
                        lookupChartTypes = ['pie3d', 'column', 'donut', 'bar'],
                        dates = [],
                        dateCount = 0,
                        dateChartCount = 0,
                        dateChartTypes = ['line', 'column', 'area'],
                        lookupAndDateChartCount = 0,
                        lookupAndDateChartTypes = ['columnstacked-top5', 'area-top7', 'column-top5', 'barstacked-top5'],
                        currency = [],
                        groupExpressions = dataView.groupExpression(),
                        hasMap = false;

                    dataView.AutoPivots = {};

                    function getNextLookupChart() {
                        return lookupChartTypes[lookupChartCount++ % lookupChartTypes.length];
                    }
                    function getNextDateChart() {
                        return dateChartTypes[dateChartCount++ % dateChartTypes.length];
                    }
                    function getNextLookupAndDateChart() {
                        return lookupAndDateChartTypes[lookupAndDateChartCount++ % lookupAndDateChartTypes.length];
                    }


                    // enumerate fields
                    $(dataView._fields).each(function () {
                        var field = this;
                        dataView.AutoPivots[field.Name] = [];
                        // lookup
                        if (field.ItemsDataController || field.AliasName)
                            lookups.push(field.Name);
                        //// group
                        //if (groupExpressions && groupExpressions[0] == field.Name)
                        //    lookups.splice(0, 0, field.Name);
                        // date
                        if (field.Type == "DateTime")
                            dates.push(field.Name)
                        // currency
                        if (field.DataFormatString == "c")
                            currency.push(field.Name);

                        if (groupExpressions && groupExpressions[0] == (field.AliasName || field.Name))
                            dataView.AutoPivots[field.Name].push('pivot' + pivotCount++ + "-row1-top10-sortdescbyvalue-" + (field.Type == 'String' ? 'pie-other' : 'column'));
                    });

                    $(lookups).each(function () {
                        if (pivotCount > 9 || !dates[dateCount])
                            return false;

                        var lookup = this,
                            date = dates[dateCount];

                        dataView.AutoPivots[lookups[lookupCount++ % lookups.length]].push('pivot' + pivotCount + '-col1-sortdescbyvalue-' + getNextLookupAndDateChart());
                        dataView.AutoPivots[dates[dateCount++ % dates.length]].push('pivot' + pivotCount++ + '-row1-date-all-hideblank');
                    });

                    lookupCount = 0;
                    dateCount = 0;

                    // create auto pivots
                    $(dataView._fields).each(function () {
                        // max # of pivots
                        if (pivotCount > 9)
                            return false;

                        var field = this,
                            name = field.Name;

                        if (field.IsPrimaryKey)
                            return true;

                        if (field.ItemsDataController || field.AliasName) {
                            dataView.AutoPivots[name].push('pivot' + pivotCount++ + "-row1-top10-other-sortdescbyvalue-" + getNextLookupChart());
                        }
                        switch (field.Type) {
                            case "Int16":
                            case "Int32":
                            case "Int64":
                            case "Single":
                            case "Double":
                            case "Decimal":
                                if (lookups.length != 0 && !(field.ItemsDataController || field.AliasName)) {
                                    var valueMode = 'sum', chartType = getNextLookupChart();
                                    if (name.match(/salary/i))
                                        valueMode = 'avg';
                                    else if (name.match(/total/i))
                                        valueMode = 'sum';
                                    else if (field.DataFormatString == '{0:c}' || name.match(/price|discount/i)) {
                                        valueMode = 'avg';
                                        while (isPieChart(chartType))
                                            chartType = getNextLookupChart();
                                    }
                                    if (isPieChart(chartType))
                                        valueMode = 'sum';
                                    dataView.AutoPivots[name].push('pivot' + pivotCount + '-val1-' + valueMode + '-' + chartType);
                                    dataView.AutoPivots[lookups[lookupCount++ % lookups.length]].push('pivot' + pivotCount++ + '-row1-top7-other-sortdescbyvalue');
                                }
                                break;
                            case "DateTime":
                                if (name.match(/birth|hire/i))
                                    dataView.AutoPivots[name].push('pivot' + pivotCount++ + '-row1-month-all-pie3d');
                                else
                                    dataView.AutoPivots[name].push('pivot' + pivotCount++ + '-row1-' + getNextDateChart() + '-date-all-hideblank');
                                break;
                            case "String":
                                if (!hasMap) {
                                    if (name.match(/country/i))
                                        dataView.AutoPivots[name].push('pivot' + pivotCount++ + '-row1-geo');
                                }
                                break;
                        }
                    });



                    if (pivotCount > 1)
                        isSupported = true;
                }
            }
            return isSupported;
        },
        show: function (options) {
            var that = this,
                dataView = $app.find(options.id),
                filter = dataView._filter,
                taggedFields = [],
                chartList = options.container.find('.app-chart-list'),
                pivots = options.container.data('pivots'),
                chartsConfig = dataView.viewProp('chartsConfig') || {};

            // show an empty list with refresh and clear filter buttons. If (showDataWarning), shows warning about too many records
            function renderEmptyList(showDataWarning) {
                emptyChartList();
                var listview = $('<ul class="app-listview app-grid"/>').appendTo(chartList);

                if (!showDataWarning) {
                    var refreshLink = $('<li data-icon="refresh"><a href="#app-refresh" class="ui-btn ui-icon-refresh ui-btn-icon-left"><p/></a></li>').appendTo(listview).find('a');
                    refreshLink.attr('title', Web.DataViewResources.Pager.Refresh).find('p').text(Web.DataViewResources.Data.NoRecords);

                    if (dataView._filter && dataView._filter.length && !dataView.filterIsExternal()) {
                        var clearFilterLink = $('<li data-icon="filter" class="ui-last-child"><a href="#app-clear-filter" class="ui-btn ui-icon-filter ui-btn-icon-left"><p/></a></li>').appendTo(listview).find('a');
                        clearFilterLink.attr('title', resourcesMobile.ClearFilter).find('p').text(resourcesMobile.ClearFilter);
                    }
                }
                else {
                    var filterLink = $('<li data-icon="filter" class="ui-last-child"><a href="#app-filter" class="ui-btn ui-icon-filter ui-btn-icon-left"><p/></a></li>').appendTo(listview).find('a'),
                        dataWarning = String.format(resources.DataWarning, __settings.maxPivotRowCount)
                    filterLink.attr('title', resourcesMobile.Filter).find('p').text(dataWarning);
                }
                listview.listview();
            }

            function emptyChartList() {
                chartList.find('.app-chart').each(function () {
                    $(this).removeData();
                });
                chartList.empty();
            }

            // translate all words in each pivot
            function translate(pivots) {
                // pivots
                for (pivot in pivots) {
                    // translate data
                    $(pivots[pivot].Data).each(function () {
                        var row = this,
                            i = 0;
                        while (i < row.length) {
                            row[i] = translateWord(row[i]);
                            i++
                        }
                    });

                    // translate label
                    pivots[pivot].Title = translateWord(pivots[pivot].Title);

                    // convert nulls to 0
                    pivots[pivot].ChartData = JSON.parse(JSON.stringify(pivots[pivot].Data));
                    $(pivots[pivot].ChartData).each(function () {
                        var pivot = this;
                        var row = this,
                            i = 0;
                        for (i = 0; i < row.length; i++) {
                            if (row[i] == null)
                                row[i] = 0;
                        }
                    });
                }
            }

            // translate a word
            function translateWord(word) {
                if (!word || !isNaN(word) || isFinite(word))
                    return word;

                var matches = word.match(/\$(\S+)/g);

                $(matches).each(function () {
                    var wordWithoutNum = this.replace(/\d*/g, ''),
                        match = wordWithoutNum.replace(/[$\d]*/g, ''),
                        replacement = resources.ChartLabels[match];
                    if (replacement) {
                        if (match.match(/Quarter|Week/))
                            replacement = replacement.substring(0, 1);
                        word = word.replace(wordWithoutNum, replacement);
                    }
                    else if (match == 'CurrentViewLabel')
                        word = word.replace(wordWithoutNum, dataView._view.Label);
                    if (match == 'Other')
                        word.isOther = true;
                });
                return word;
            }

            function render() {
                var w,
                    h,
                    maxHeight,
                    pivot,
                    pivotName,
                    chartContainers = [],
                    chartIndex = 0,
                    scrollable = chartList.closest('.app-wrapper'),
                    instruction,
                    numberOfPivots = 0,
                    numberOfColumns = 1,
                    testCharts,
                    oldCharts = chartList.find('.app-chart'),
                    resizedPlaceholder,
                    closestPlaceholder,
                    hasLargerChart = false;
                if (oldCharts.length > 0) {
                    var scrollableTop = scrollable.scrollTop();
                    $(oldCharts).each(function () {
                        var chart = $(this);
                        if (chart.position().top > 0) {
                            chartsConfig[chart.data('data-context').Id].lastScrollPosition = true;
                            return false;
                        }
                    });
                }
                emptyChartList();
                $('<div class="app-chart"><span class="app-chart-inner"/></div><div class="app-chart"><span class="app-chart-inner"/></div><div class="app-chart"><span class="app-chart-inner"/></div>').appendTo(chartList);
                testCharts = chartList.find('.app-chart')
                if ($(testCharts[0]).offset().left < $(testCharts[1]).offset().left)
                    numberOfColumns++;
                if ($(testCharts[1]).offset().left < $(testCharts[2]).offset().left)
                    numberOfColumns++;
                testCharts.remove();
                chartList.empty();
                // count number of valid pivots
                for (pivotName in pivots) {
                    pivot = pivots[pivotName];
                    if (!pivot.ChartType || pivot.RecordCount == 0)
                        continue;
                    else {
                        // check if there's a larger chart
                        if (!hasLargerChart) {
                            if (pivot.Properties["medium"] || pivot.Properties["large"])
                                hasLargerChart = true;
                            else if (chartsConfig) {
                                var config = chartsConfig[pivot.Id];
                                if (config && config.size && (config.size.match(/medium|large/)))
                                    hasLargerChart = true;
                            }
                        }
                        numberOfPivots++;
                    }
                }
                if (numberOfPivots == 1)
                    hasLargerChart = true;
                // calculate pivot size
                for (pivotName in pivots) {
                    pivot = pivots[pivotName],
                        placeholder = $('<div class="app-chart"></div>').data('data-context', pivot),
                        inner = $('<span class="app-chart-inner"></span>').appendTo(placeholder),
                        moreBtn = $('<a class="ui-btn"><span class="app-btn-more">&nbsp;</span></a>').appendTo(placeholder).attr('title', resources.More);

                    if (!pivot.ChartType || pivot.RecordCount == 0)
                        continue;

                    placeholder.appendTo(chartList);

                    if (!w) {
                        maxHeight = scrollable.height(); // 90 - height of promo-filler
                        //if (hasLargerChart)
                        //    maxHeight -= 90;
                        instruction = scrollable.find('.app-presenter-instruction:visible');
                        if (instruction.length)
                            maxHeight -= instruction.outerHeight();
                        maxHeight = Math.floor(maxHeight);
                        w = inner.width();
                        if (numberOfColumns == 3)
                            h = numberOfPivots <= 3 ? Math.min(maxHeight, w * 1.33) : Math.min(w * .66, Math.max(maxHeight / 3, w * .5)) - 1;
                        else if (numberOfColumns == 2)
                            h = numberOfPivots <= 4 ? Math.max(maxHeight / 2, w * .5) : w * .66;
                        else
                            h = maxHeight * .66;
                        if (hasLargerChart && numberOfPivots <= 3)
                            h = maxHeight * .5;
                        if (h > maxHeight) {
                            h = w * .66;
                            if (h > maxHeight)
                                h = maxHeight;
                        }
                        h = Math.floor(h);
                    }

                    var thisH = h;

                    // get configured height
                    var config = chartsConfig[pivot.Id];
                    if (!config)
                        config = chartsConfig[pivot.Id] = {};

                    // read tags
                    if (!config.size) {
                        if (pivot.Properties["small"] != null)
                            delete config.size;
                        else if (pivot.Properties["medium"] != null)
                            config.size = "medium";
                        else if (pivot.Properties["large"] != null)
                            config.size = "large";
                    }

                    // set height
                    if (config.size) {
                        if (config.size == "medium") {
                            if (numberOfPivots > 2)
                                thisH = h * 2 + 1;
                            placeholder.addClass('app-chart-medium');
                        }
                        else if (config.size == "large") {
                            thisH = maxHeight;
                            placeholder.addClass('app-chart-large');
                        }
                    }

                    // single pivot will always be full screen
                    if (numberOfPivots == 1) {
                        placeholder.addClass('app-chart-large');
                        thisH = maxHeight;
                    }

                    // scroll to
                    if (config.resized) {
                        resizedPlaceholder = placeholder;
                        delete config.resized;
                    }
                    else if (config.lastScrollPosition) {
                        closestPlaceholder = placeholder;
                        delete config.lastScrollPosition;
                    }

                    // ShowData 
                    if (config.ShowData || pivot.ChartType == "table")
                        pivot.ShowData = true;
                    else if (pivot.ShowData)
                        pivot.ShowData = false;

                    // ensure min height
                    if (thisH < 150)
                        thisH = 150;
                    chartContainers.push(inner.height(thisH));
                }
                $('<div class="app-clear-fix"></div>').appendTo(chartList);
                setTimeout(function () {
                    for (pivotName in pivots) {
                        pivot = pivots[pivotName];

                        if (!pivot.ChartType || pivot.RecordCount == 0)
                            continue;

                        // draw table with chart in corner.
                        if (pivot.ShowData) {
                            drawData(pivot, $(chartContainers[chartIndex++]));
                        }
                        else
                            drawChart(pivot, chartContainers[chartIndex++])
                    }
                }, 10);

                if (numberOfPivots == 0)
                    renderEmptyList(false);

                if (chartList.closest('.app-echo').length == 0)
                    $('<div class="app-promo-filler"></div>').appendTo(chartList);


                dataView.viewProp('chartsConfig', chartsConfig);

                if (numberOfPivots > 1)
                    if (resizedPlaceholder || closestPlaceholder) {
                        var scrollToPlaceholder = resizedPlaceholder || closestPlaceholder,
                            placeholderHeight = scrollToPlaceholder.outerHeight(),
                            space = (scrollable.height() - placeholderHeight) / 2,
                            newScrollTop = scrollToPlaceholder.offset().top - scrollable.offset().top - space;
                        //if (newScrollTop > placeholderHeight / 3)
                        touch.scroll(scrollable, newScrollTop);
                    }

            }

            if (chartList.length == 0)
                chartList = $('<div class="app-chart-list"></div>').appendTo(options.container);

            if (options.reset || pivots && dataView.dataSignature() != options.container.data('signature'))
                pivots = null;

            if (dataView._totalRowCount > __settings.maxPivotRowCount) {
                renderEmptyList(true);
                return;
            }

            if (!pivots || pivots.length == 0) {
                chartList.find('.app-chart-inner').children().hide();
                $app.execute({
                    controller: dataView._controller,
                    command: 'Pivot',
                    pivotDefinitions: dataView.AutoPivots,
                    view: dataView._viewId,
                    _filter: dataView.combinedFilter(),
                    sort: '',
                    tags: dataView.get_tags(),
                    success: function (result) {
                        pivots = result.Pivots;
                        translate(pivots);
                        options.container.data('signature', dataView.dataSignature());
                        options.container.data('pivots', pivots);
                        if (apiLoaded)
                            render();
                        else {
                            touch.registerAPI('Charts', function () {
                                apiLoaded = true;
                                render();
                            });
                        }
                    },
                    error: function (error) {
                        $app.alert(String.format('{0}\n{1}', error.get_message(), error.get_stackTrace()));
                    }
                });
            }
            else
                render();

        },
        hide: function (options) {
        },
        dispose: function (options) {
            options.container.removeData('pivots signature');
            options.container.find('app-chart').each(function () {
                $(this).removeData();
            });
        }
    });
})();
(function () {

    var $window = $(window),
        $mobile = $.mobile,
        touch = $app.touch,
        loadedPackages = {},
        resources = Web.DataViewResources,
        resourcesPager = resources.Pager,
        resourcesHeaderFilter = resources.HeaderFilter,
        resourcesCalendar = resources.Presenters.Calendar,
        resourcesMobile = resources.Mobile,
        dtf = Sys.CultureInfo.CurrentCulture.dateTimeFormat,
        currentDate = new Date(),
        currentDay = new Date(currentDate.getFullYear(), currentDate.getMonth(), currentDate.getDate()),
        currentYear = currentDate.getFullYear(),
        currentMonth = currentDate.getMonth(),
        tagRegex = /calendar(\d+)?-([a-zA-Z]+)(:['"]?([a-zA-Z]+)['"]?)?(\d+)?/g,
        pivotRegex = /^(\d+), (\d+), (\d+)(, (.*))?$/,
        isScrolling,
        scrollStopTimeout,
        scrollStopCallback,
        dragScrollTimeout,
        shiftViewTimeout,
        swipeEventTimeout,
        pluginLoadDataTimeout,
        drawTimeTimeout,
        loadColorLegendTimeout,
        saveColorsTimeout,
        dropTimeTimeout,
        updatePluginTimeout,
        drawTimeInterval,
        animationSpeed = 500,
        timeoutSpeed = 100,
        refreshSpeed = 250,
        weekTimeWidth = 66,
        dayScrollEventCount = 0,
        weekCurrentDayMarginLeft = 0,
        dayAndWeekHeight = 1060,
        modeDrawDistance = {
            year: 2,
            month: 2,
            week: 7,
            day: 1, // in weeks
            agenda: 1
        },
        modeMaxRender = {
            year: 5,
            month: 5,
            week: 21,
            day: 2, // in weeks
            agenda: 90
        },
        eventMinLength = 30, // in minutes
        agendaPageSize = 30,
        maxColorCount = 23,
        maxLegendVisible = 5,
        dtfDayOfWeek = [], // to get proper day # by culture - dtfDayOfWeek[date.getDay()]
        dayOfWeekDtf = [], // to get the proper day name - dtf.DayNames[dayOfWeekDtf[day]]
        skipClick,
        draggedCalendarEvent,
        miniCalendarHeaderFormat = '<a class="ui-btn app-has-droparrow app-month-picker">{0}</a> <a class="ui-btn app-has-droparrow app-year-picker">{1}</a>',
        monthMoreFormat = '+{0} <span class="app-month-more">' + resourcesMobile.More.toLowerCase() + '</span>';

    // init dtf conversion
    for (var i = 0; i < 7; i++) {
        dtfDayOfWeek[i] = (7 + i - dtf.FirstDayOfWeek) % 7;
        dayOfWeekDtf[i] = (i + dtf.FirstDayOfWeek) % 7;
    };

    // check if point is touch or mouse
    function isNotTouch() {
        // return touch.desktop();
        return (navigator.platform.match(/Win\d+|Mac/i) != null) && (!navigator.maxTouchPoints || navigator.maxTouchPoints == 0);
    }

    function appendClearFix(placeholder) {
        $('<div class="app-clear-fix"></div>').appendTo(placeholder);
    }

    function startDrawTime() {
        if (drawTimeTimeout)
            return;
        var now = new Date();
        drawTimeTimeout = setTimeout(function () {
            drawTimeInterval = setInterval(drawTime, 1000 * 60);
        }, (60 - now.getSeconds()) * 1000);
    }

    // recalculates and moves current time lines on the screen
    // use mode = find to find the correct top
    function drawTime(date, mode, callback) {
        if (!date && $('.app-calendar.app-has-time-prompt').length)
            return;

        var now = date || new Date(),
            nowText = getClockTime(now),
            timeCols = $('.app-calendar-time'),
            timeLines,
            times = timeCols.find('div.app-current-time'),
            height = dayAndWeekHeight - (dayAndWeekHeight / 25),
            nowTime = now.getTime(),
            minutes = now.getMinutes(),
            startDayTime = new Date(now.getFullYear(), now.getMonth(), now.getDate()).getTime(),
            ms = nowTime - startDayTime,
            hours = timeCols.find('li span'),
            minute = now.getMinutes(),
            difference = 5 * (3000 / dayAndWeekHeight);

        if (mode && minutes != 0)
            nowText = ':' + minutes;

        if (!mode)
            timeLines = $('.app-calendar-weekview .current-time-line, .app-calendar-dayview .current-time-line');
        else if (mode == 'week') {
            $('.app-calendar').addClass('app-has-time-prompt');
            timeLines = $mobile.activePage.find('.app-calendar-weekview .current-time-line')
        }
        else
            timeLines = $('.app-calendar-dayview .current-time-line');

        var fraction = ms / 86400000, // milliseconds in a day
            top = height * fraction;
        if (mode == 'find')
            drawTime();
        else if (times.first().css('top') != top + 'px')
            touch.callInAnimationFrame(function () {

                if (nowText != '') {
                    // hide covered hours
                    hours.removeClass('time-hidden');
                    if (minute < difference)
                        hours.filter('span[data-cal-hour="' + now.getHours() + '"]').addClass('time-hidden');
                    else if (minute > (60 - difference))
                        hours.filter('span[data-cal-hour="' + (now.getHours() + 1) + '"]').addClass('time-hidden');

                    times.text(nowText);
                }

                times.css('top', top);
                timeLines.css('top', top).data('date', now);

                if (callback)
                    callback(top);
            });
        return top;
    }

    function getClockTime(now, addSpace, brief) {
        if (!now)
            return '';
        var hour = now.getHours(),
            minute = now.getMinutes(),
            second = now.getSeconds(),
            pmDesignator = dtf.PMDesignator,
            amDesignator = dtf.AMDesignator,
            ap = hour < 12 ? (brief ? '' : amDesignator) : (brief ? pmDesignator.substring(0, 1) : pmDesignator);
        if (hour > 12 && (amDesignator || pmDesignator)) {
            hour = hour - 12;
        }
        if (addSpace && hour < 10 && hour != 0)
            hour = '0' + hour;
        if (hour == 0)
            hour = (pmDesignator || amDesignator) ? 12 : 0;
        if (minute < 10)
            minute = "0" + minute;
        if (!brief && ap)
            ap = ' ' + ap;

        return brief && minute == '00' ? String.format('{0}{1}', hour, ap) : String.format('{0}:{1}{2}', hour, minute, ap);
    }

    function setDateFraction(date, hour, frac) {
        if (frac < 0.125)
            date.setHours(hour);
        else if (frac < 0.375)
            date.setHours(hour, 15);
        else if (frac < 0.625)
            date.setHours(hour, 30);
        else if (frac < 0.875)
            date.setHours(hour, 45);
        else
            date.setHours(hour, 60);
    }

    function isToday(testDate) {
        return testDate.getDate() == currentDate.getDate() && testDate.getMonth() == currentMonth && testDate.getFullYear() == currentYear;
    }

    function isSameDay(a, b) {
        return a.getDate() == b.getDate() && a.getMonth() == b.getMonth() && a.getFullYear() == b.getFullYear();
    }

    // gets the first placeholder visible on the screen
    function getFirstVisiblePlaceholder(placeholders) {
        var first;
        placeholders.each(function () {
            first = $(this);
            firstLeft = first.position().left;
            if (firstLeft > 0 || firstLeft * -1 < first.width() / 2)
                return false;
        });
        return first;
    }

    var Cache = function (calendar) {
        this.calendar = calendar;
        this.data = { day: {}, month: {}, year: {}, agenda: {} };
    }

    Cache.prototype = {
        select: function (start) {

            var mode = this.calendar.mode,
                date = new Date(start),
                month,
                days = 1;
            if (mode == "week")
                mode = "day";
            else if (mode == "agenda")
                return this.data[mode][start];
            var year = this.data[mode][date.getFullYear()];

            // get year
            if (!year)
                return null;
            if (mode == 'year')
                return year;

            // get month
            month = year[date.getMonth()];
            if (!month)
                return null;
            if (mode == 'month')
                return month;

            // get day/week
            return month[date.getDate()];
        },
        insert: function (start, rows) {
            var testDate = new Date(start),
                dataView = this.dataView,
                activeField = this.calendar.activeCalendar.date,
                mode = this.calendar.mode,
                days = mode == 'week' ? 7 : 1;
            if (mode == "week")
                mode = "day";
            else if (mode == "agenda") {
                if (start < 0)
                    rows.reverse();
                this.data[mode][start] = rows;
                return;
            }

            switch (mode) {
                case 'year':
                    this.data[mode][start.getFullYear()] = {};
                    break;
                case 'month':
                    var year = this.data[mode][start.getFullYear()];
                    if (!year)
                        year = this.data[mode][start.getFullYear()] = {};
                    year[start.getMonth()] = {};
                    break;
                case 'day':
                    var test = new Date(start);
                    for (i = 0; i < days ; i++) {
                        var year = this.data[mode][test.getFullYear()];
                        if (!year)
                            year = this.data[mode][test.getFullYear()] = {};
                        var month = year[test.getMonth()];
                        if (!month)
                            month = year[test.getMonth()] = {};
                        month[test.getDate()] = { rows: [], count: 0 };
                        test.setDate(test.getDate() + 1);
                    }
                    break;
            }

            for (var rowNum in rows) {
                var row = rows[rowNum],
                    value = pivotRegex.exec(row[0]);
                if (!value) {
                    //alert("Error with: " + row[0]);
                    continue;
                }
                var date = new Date(value[1], parseInt(value[2]) - 1, value[3] || value[2]),
                    year = this.data[mode][date.getFullYear()];
                if (!year)
                    year = this.data[mode][date.getFullYear()] = {};
                var month = year[date.getMonth()];
                if (!month)
                    month = year[date.getMonth()] = {};
                var day = month[date.getDate()];
                if (!day)
                    day = month[date.getDate()] = { rows: [], count: 0 };
                if (mode == 'year') {
                    day.count = row[1];
                }
                else {
                    $(row[1]).each(function () {
                        if (this.length == 5)
                            day.rows.push(this);
                    });
                    day.count += row[2];
                }
            }
        },
        // clears the cached data and reloads data in the visible view
        clear: function () {
            this.data = { day: {}, month: {}, year: {}, agenda: {} };

        },
        clearAgenda: function () {
            this.data.agenda = {};
        }
    }

    // get data view's combined filter with specified additional between
    function getDateFilter(dataView, startField, endField, start, end) {
        //var startName = startField.Name,
        //    endName = endField ? endField.Name : '',
        //    lastMatchIndex = -1,
        //    removeIndices = [],
        //    newFilter = dataView.combinedFilter().filter(function (f, i) {
        //        if (f.startsWith("_match"))
        //            lastMatchIndex = i;
        //        if (f.startsWith(startName) || (endField && f.startsWith(endName))) {
        //            if (lastMatchIndex != -1)
        //                removeIndices[lastMatchIndex] = i;
        //            else
        //                return false;
        //        }
        //        return true;
        //    }),
        //    start = dataView.convertFieldValueToString(startField, start),
        //    end = dataView.convertFieldValueToString(startField, end),
        //    betweenFilter = String.format('{0}:$between${1}$and${2}', startName, start, end),
        //    startLTE = String.format('{0}:<={1}', startName),
        //    startGTE = String.format('{0}:>={1}', startName),
        //    endLTE = String.format('{0}:<={1}', endName),
        //    endGTE = String.format('{0}:>={1}', endName);
        //for (var s in removeIndices)
        //    if (removeIndices.hasOwnProperty(s))
        //        newFilter.splice(removeIndices[s], parseInt[s]);
        //if (!endField)
        //    newFilter.push(betweenFilter);
        //else 
        //    newFilter.push(
        //        "_match_:$all$", betweenFilter,
        //        "_match_:$all$", startLTE, endGTE,
        //        "_match_:$all$", startLTE, endGTE);

        var newFilter = dataView.combinedFilter().filter(function (f) {
            return !f.startsWith(startField.Name)
        }),
            dateString1 = dataView.convertFieldValueToString(startField, start),
            dateString2 = end && dataView.convertFieldValueToString(startField, end),
            dateFilter;

        if (start == null)
            dateFilter = String.format('{0}:<{1}', startField.Name, dateString2);
        else if (end == null)
            dateFilter = String.format('{0}:>={1}', startField.Name, dateString1);
        else
            dateFilter = String.format('{0}:$between${1}$and${2}', startField.Name, dateString1, dateString2);
        if (start && (isNaN(start.getTime())) || (end && isNaN(end.getTime()))) {
            if (console && console.log)
                console.log('Error forming date filter: Date is NaN');
            return newFilter;
        }
        newFilter.push(dateFilter);
        return newFilter;
    }

    // reads block attributes and returns Date object
    function getDateOfBlock(placeholder) {
        var year = placeholder.attr('data-cal-year'),
            month = placeholder.attr('data-cal-month'),
            day = placeholder.attr('data-cal-day');
        return new Date(year, month ? month : 0, day ? day : 1);
    }

    // creates month table string
    function createMonthTableBody(year, month, forMiniCalendar) {
        var body = '',
            testDate = new Date(year, month, 1),
            dayOfWeek = dtfDayOfWeek[testDate.getDay()],
            endDate = new Date(year, month + 1, 1),
            endDay = dtfDayOfWeek[endDate.getDay()],
            currentRow = '',
            rowCount = 0,
            isCurrentMonth = false,
            drawnTdCount = 0,
            maxTdCount = 42;

        // set the end date
        if (endDay != 0)
            endDate.setDate(endDate.getDate() + (6 - endDay) + 1);

        // set the start date
        if (dayOfWeek != 0)
            testDate.setDate(testDate.getDate() - dayOfWeek);

        // render this month
        while (drawnTdCount < maxTdCount) {
            dayOfWeek = dtfDayOfWeek[testDate.getDay()];
            if (dayOfWeek == 0) {
                if (currentRow)
                    body += currentRow + '</tr>';
                rowCount++;
                currentRow = '<tr>';
            }
            currentRow += '<td';
            var testMonth = testDate.getMonth();
            if (testMonth == month || forMiniCalendar) {
                if (forMiniCalendar && testMonth != month) {

                    if (!(month == 11 && testMonth == 0) && ((month == 0 && testMonth == 11) || testMonth < month))
                        currentRow += ' class="app-prev-month"';
                    else
                        currentRow += ' class="app-next-month"';
                }
                else if (currentDay.setHours(0, 0, 0, 0) == testDate.setHours(0, 0, 0, 0))
                    currentRow += ' class="app-current-day"';
                if (forMiniCalendar)
                    currentRow += String.format(' data-cal-month="{0}" data-cal-day="{1}"', testDate.getMonth(), testDate.getDate());
                currentRow += String.format('>{0}', testDate.getDate());
            }
            else
                currentRow += '>&nbsp;';

            currentRow += '</td>';
            testDate.setDate(testDate.getDate() + 1);
            drawnTdCount++;
            if (!forMiniCalendar)
                if (testDate >= endDate)
                    break;
        }
        body += currentRow;
        // flesh out rows
        while (rowCount < 6) {
            rowCount++;
            body += '<tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>';
        }
        return body + '';
    }

    // find tab and click
    function clickOnCalendarTab(_, link) {
        $mobile.activePage.find('.app-tabs .ui-btn').each(function () {
            var tab = $(this);
            if (tab.attr('data-text') == link.text()) {
                tab.trigger('vclick');
                return false;
            }
        });
    }

    // finds the correct tab link
    function findTab(header, text) {
        var tabs = header.find('.app-tabs a'),
            link;

        tabs.each(function () {
            var tab = $(this);
            if (tab.attr('data-text') == text) {
                link = tab;
                return false;
            }
        });
        return link;
    }

    // reads in the calendar tags
    function composeCalendars(dataView) {
        var isChild = dataView.get_hasParent(),
            filterFields = dataView.get_filterFields(),
            autoCalendars = [],
            calendars = [],
            firstString,
            firstLookup, secondLookup,
            firstDate;

        $(dataView._allFields).each(function () {
            var field = this;

            // check for tags
            if (field.Tag) {
                match = tagRegex.exec(field.Tag);
                while (match != null) {
                    var id = match[1] ? parseInt(match[1]) : 0,
                        prop = match[2],
                        val = match[4],
                        calendar = calendars[id];

                    if (prop == 'disabled')
                        break;

                    //if (field.AliasName)
                    //    field = dataView.findField(field.AliasName);

                    if (!calendar)
                        calendars[id] = (calendar = {});

                    switch (prop) {
                        case "date":
                            calendar.date = field;
                            break;
                        default:
                            calendar[prop] = !!val ? val : field;
                            break;
                    }

                    match = tagRegex.exec(field.Tag);
                }
            }

            if ((field.ItemsDataController || field.AliasName) && field.ItemsStyle != 'CheckBoxList') {
                if (!isChild || field.Name != filterFields) {
                    if (!firstLookup)
                        firstLookup = field;
                    else if (!secondLookup)
                        secondLookup = field;
                }
            }

            if (!firstString && field.Type == 'String')
                firstString = field;

            // auto create tags
            if (field.Type == "DateTime" || field.Type == "Date") {
                if (!field.tagged('calendar-disabled')) {
                    if (!firstDate)
                        firstDate = field;
                    var i = 0;
                    while (autoCalendars[i])
                        i++;
                    autoCalendars[i] = {
                        date: field,
                        name: field.Label
                    };
                }
            }
        });

        if ($.isEmptyObject(calendars))
            calendars = autoCalendars;

        // verify properties
        $(calendars).each(function () {
            var calendar = this;

            if (!calendar.text && firstString)
                calendar.text = firstString;

            if (!calendar.date && firstDate)
                calendar.date = firstDate;

            if (!calendar.name)
                calendar.name = calendar.date.Label;

            if (firstLookup && !calendar.color) {
                if (firstString && secondLookup && firstString == firstLookup)
                    calendar.color = secondLookup;
                else
                    calendar.color = firstLookup;
            }

            var cachedColorMap = calendar.color ? dataView.viewProp('calendarColorMap-' + calendar.color.Name) : null;
            calendar.colorMap = new ColorMap(dataView, calendar, cachedColorMap);
        });

        return calendars;
    }

    function dragY2PageY(event, scrollable, calendar) {
        // layerY is depreciated in Chrome
        var originalEvent = event.originalEvent,
            grid = scrollable.find(calendar.mode == 'week' ? '.app-calendar-week-grid' : '.app-calendar-day-grid'),
            timeline = grid.find('.current-time-line'),
            pageY = originalEvent.pageY != null ?
                    (
                        originalEvent.pageY - scrollable.offset().top + scrollable.scrollTop() -
                        (grid.offset().top + scrollable.scrollTop() - scrollable.offset().top) -
                        (touch.toPixels(timeline.css('margin-top')))
                    ) :
                    (originalEvent.layerY - 22);
        return pageY;
    }

    function fetchCalendarData(scrollable, afterResize) {

        var dataView = touch.dataView(),
            calendar = dataView && dataView.calendar,
            viewStyle = dataView && dataView.extension().viewStyle;

        if (!scrollable)
            scrollable = calendar.scrollable();
        var presenter = scrollable.find('.app-presenter[data-presenter="calendar"]'),
            header = presenter.data('cal-header'),
            footer = presenter.data('cal-footer'),
            viewClass = calendar.viewClassName(),// '.app-calendar-' + calendar.mode + 'view',
            view = presenter.find(viewClass);

        // execute
        if (afterResize) {
            calendar.preventNavigate = true;
            calendar.getViewHandler().resize(view, header, footer, true);
        }
        if (scrollStopCallback)
            scrollStopCallback();
        calendar.updateHeader(header);
        calendar.loadData(view);
        dataView.calendarPlugin.refresh();

    }
    $(document)
        // global scroll handler
        .on('scrollstart.app', function () {
            isScrolling = true;
        })
        .on('scroll.app scrollstop.app resized.app', function (event) {
            isScrolling = false;
            var dataView = touch.dataView(),
                calendar = dataView && dataView.calendar,
                viewStyle = dataView && dataView.extension().viewStyle(),
                resized = event.type == 'resized';

            if (!dataView || viewStyle != 'calendar' || !calendar)
                return;

            var isDayWeek = calendar.mode.match(/day|week/);

            if (resized && isDayWeek) {
                var scrollable = calendar.scrollable(),
                    presenter = scrollable.find('div[data-presenter="calendar"]'),
                    header = presenter.data('cal-header'),
                    view = calendar.getVisibleView();
                if (view)
                    view.removeClass('app-has-current-day');
                if (header)
                    header.find('.app-week-header ul, .app-day-header ul').css('visibility', 'hidden');
            }

            // handle scroll stop
            clearTimeout(scrollStopTimeout);
            scrollStopTimeout = setTimeout(function () {
                // show/hide heading
                if (!isScrolling && (resized || !isDayWeek)) {
                    fetchCalendarData(event.relatedTarget, resized);
                }
            }, 300);

        })

    // swipeleft handler - move right
    .on('swipeleft', '.app-calendar-dayview, .app-day-header, .app-calendar-weekview, .app-week-header', function (event) {
        event.preventDefault();
        skipClick = true;
        clearTimeout(swipeEventTimeout);
        swipeEventTimeout = setTimeout(function () {
            var dataView = touch.dataView(),
                calendar = dataView.calendar;
            if (calendar)
                calendar.scrollView('next');
        }, timeoutSpeed);
    })
    // swiperight handler
    .on('swiperight', '.app-calendar-dayview, .app-day-header, .app-calendar-weekview, .app-week-header', function (event) {
        event.preventDefault();
        skipClick = true;
        clearTimeout(swipeEventTimeout);
        swipeEventTimeout = setTimeout(function () {
            var dataView = touch.dataView(),
                calendar = dataView.calendar;
            if (calendar)
                calendar.scrollView('prev');
        }, timeoutSpeed);
    })

    // scrollwheel left/right handler
    .on('wheel', '.app-calendar-dayview, .app-day-header, .app-calendar-weekview, .app-week-header', function (event) {
        return;
        var eo = event.originalEvent;
        if (Math.abs(eo.deltaX) > 2) {
            event.preventDefault();

            if (eo.deltaX < -50) {
                // swipe right
                scrollView('prev');
            }

            else if (eo.deltaX > 50) {
                // swipe left
                scrollView('next');
            }
        }
    })

    // tabs handler
    .on('more.app', function (event) {
        var target = $(event.target),
            echo = target.closest('.app-echo'),
            dataView = echo.length ? $app.find(echo.attr('data-for')) : touch.dataView(),
            scrollable = $.mobile.activePage.find('.app-wrapper'),
            calendar = scrollable.find('.app-calendar'),
            isMore = event.type == 'more',
            isViewSelector = event.type == 'viewselector';

        if (!dataView || !calendar.length || !calendar.is(':visible'))
            return;

        var viewStyle = dataView.extension().viewStyle();
        if (viewStyle != 'calendar')
            return;

        var config = dataView.viewProp('calendarConfig'),
            mode = config.mode,
            tabs = scrollable.parent().find('.app-bar-calendar .app-tabs'),
            dayItem = { text: resourcesCalendar.Day, icon: mode == 'day' ? 'check' : false, callback: clickOnCalendarTab },
            weekItem = { text: resourcesCalendar.Week, icon: mode == 'week' ? 'check' : false, callback: clickOnCalendarTab },
            monthItem = { text: resourcesCalendar.Month, icon: mode == 'month' ? 'check' : false, callback: clickOnCalendarTab },
            yearItem = { text: resourcesCalendar.Year, icon: mode == 'year' ? 'check' : false, callback: clickOnCalendarTab },
            agendaItem = { text: resourcesCalendar.Agenda, icon: mode == 'agenda' ? 'check' : false, callback: clickOnCalendarTab };

        if (isMore && event.panel[0].id == 'app-panel-view-options')
            event.items.splice(event.items.length, 0, {}, dayItem, weekItem, monthItem, yearItem, agendaItem);
        else if (isViewSelector && tabs.css('visibility') == 'hidden')
            event.items.splice(0, 0, dayItem, weekItem, monthItem, yearItem, agendaItem, {});
    })

    // global click handler in the calendar
    .on('dragstart', '.app-calendar', function (event) {
        var dt = event.originalEvent.dataTransfer,
            target = $(event.target),
            echo = target.closest('.app-echo'),
            dataView = echo.length ? $app.find(echo.attr('data-for')) : touch.dataView(),
            calendar = dataView.calendar,
            offset = event.originalEvent.pageY - target.offset().top;
        dt.effectAllowed = 'move';
        var target = $(event.target),
            appEvent = target.closest('.app-event'),
            isDragHandle = target.is('.app-event-handle'),
            context = appEvent.data('data-context');
        if (context) {
            skipClick = true;

            draggedCalendarEvent = {
                element: appEvent,
                context: context,
                offset: offset,
                mode: 'move'
            };

            // enable preview event element;
            if (calendar.mode.match(/day|week/)) {
                var column = appEvent.closest('.app-calendar-day'),
                    width = column.width() - (calendar.mode == "day" ? 150 : 10) - 3,
                    desktopSafari = touch.desktop() && navigator.userAgent.indexOf('Safari') != -1 && navigator.userAgent.indexOf('Chrome') == -1;

                draggedCalendarEvent.preview = appEvent.clone().addClass('app-event-preview');

                if (isDragHandle) {
                    draggedCalendarEvent.mode = 'resize';
                    draggedCalendarEvent.offset = 0;
                }
                else {
                    draggedCalendarEvent.preview.css({ width: width, 'marginLeft': '0px' });
                }


                // chrome and firefox
                if (dt.setDragImage) {
                    dt.setData('text/plain', 'DAF:' + context[0]);
                    var img = desktopSafari ? event.closest('.app-calendar-day')[0] : $('<img>')[0];
                    dt.setDragImage(img, 0, 0);

                    setTimeout(function () {
                        appEvent.css('visibility', 'hidden');
                    });
                }
                    // IE
                else
                    appEvent.css('display', 'none');
            }

        }
        touch.stickyHeaderBar().hide().addClass('app-disabled');
    })
    .on('dragend', '.app-calendar', function (event) {
        if (!draggedCalendarEvent)
            return;

        var target = $(event.target),
            echo = target.closest('.app-echo'),
            dataView = echo.length ? $app.find(echo.attr('data-for')) : touch.dataView(),
            calendar = dataView.calendar;
        $('.app-calendar').removeClass('app-has-time-prompt');
        setTimeout(drawTime, timeoutSpeed * 2);
        if (!draggedCalendarEvent.dropped) {
            draggedCalendarEvent.element.css({ visibility: '', display: '' });
            if (draggedCalendarEvent.preview)
                draggedCalendarEvent.preview.remove();
        }
        if (draggedCalendarEvent.preview && draggedCalendarEvent.preview.length)
            draggedCalendarEvent.preview = null;
        draggedCalendarEvent = null;
        touch.stickyHeaderBar().removeClass('app-disabled');
        calendar.preventNavigate = true;
    })
    .on('dragover', '.app-calendar', function (event) {
        if (!draggedCalendarEvent)
            return;

        var target = $(event.target),
            echo = target.closest('.app-echo'),
            dataView = echo.length ? $app.find(echo.attr('data-for')) : touch.dataView(),
            calendar = dataView && dataView.calendar,
            canDrag = false,
            dropTarget,
            startDate,
            scrollable,
            preview;

        if (!dataView || !calendar)
            return;

        scrollable = calendar.scrollable();
        startDate = draggedCalendarEvent.context[1];
        preview = draggedCalendarEvent.preview;

        switch (calendar.mode) {
            case 'day':
            case 'week':
                dropTarget = target.closest('.app-calendar-day,.current-time-line');
                if (dropTarget.length) {
                    canDrag = true;

                    var oEvent = event.originalEvent,
                        date = dropTarget.is('.current-time-line') ? dropTarget.data('date') : getDateOfBlock(dropTarget),
                        pageY = dragY2PageY(event, scrollable, calendar) - draggedCalendarEvent.offset,
                        hourHeight = dayAndWeekHeight / 25,
                        hourPos = pageY / hourHeight,
                        distFromTop = oEvent.pageY - scrollable.position().top,
                        distFromBottom = scrollable.height() - distFromTop;
                    if (draggedCalendarEvent.mode == 'resize' && !draggedCalendarEvent.appended) {
                        draggedCalendarEvent.appended = true;
                        draggedCalendarEvent.preview.appendTo(dropTarget.find('ul.app-calendar-eventlist'));
                    }

                    if (!dragScrollTimeout)
                        dragScrollTimeout = setTimeout(function () {
                            if (touch.desktop() && navigator.userAgent.indexOf('Chrome') == -1) {
                                // scroll if near to edge
                                if (distFromTop < 20)
                                    touch.scroll(scrollable, scrollable.scrollTop() - (20 - distFromTop));
                                else if (distFromBottom < 20)
                                    touch.scroll(scrollable, scrollable.scrollTop() + (20 - distFromBottom));
                            }
                            dragScrollTimeout = null;
                        }, 20);

                    // calculate time and position preview
                    if (hourPos > 23.75)
                        hourPos = 23.75;
                    else if (hourPos < 0)
                        hourPos = 0;
                    var hour = Math.floor(hourPos),
                        frac = hourPos - hour;
                    if (hour != null) {
                        setDateFraction(date, hour, frac);

                        if (!draggedCalendarEvent.previewDate || date.getTime() != draggedCalendarEvent.previewDate.getTime()) {
                            var drawTimeMode = calendar.mode == 'week' ? 'week' : 'find',
                                top = drawTime(date, drawTimeMode) + 22,
                                view = calendar.getVisibleView(scrollable),
                                dayColumn = calendar.getBlockByDate(view, date);

                            if (dayColumn.length) {
                                // calculate date
                                var start = draggedCalendarEvent.context[1],
                                    end = draggedCalendarEvent.context[2],
                                    minEnd = new Date(start),
                                    timeText,
                                    longTimeText;
                                minEnd.setMinutes(minEnd.getMinutes() + 30);
                                // dragging the handle
                                if (draggedCalendarEvent.mode == 'resize') {
                                    date.setFullYear(start.getFullYear(), start.getMonth(), start.getDate());
                                    if (date < minEnd)
                                        date = minEnd;
                                    timeText = getClockTime(start, false) + ' - ' + getClockTime(date, false);
                                    longTimeText = getClockTime(start, false) + ' - ' + getClockTime(date, false);

                                    preview.css('height', getEventHeight(start.getTime(), date.getTime()));
                                }
                                    // dragging the event
                                else {
                                    timeText = getClockTime(date, false, true);
                                    longTimeText = getClockTime(date);

                                    if (end) {
                                        var difference = end.getTime() - start.getTime(),
                                            newEnd = new Date(date.getTime() + difference);
                                        timeText += ' - ' + getClockTime(newEnd, false);
                                        longTimeText += ' - ' + getClockTime(newEnd, false);
                                    }

                                    preview.css('top', top);
                                    preview.appendTo(dayColumn.find('.app-calendar-eventlist'));
                                }

                                preview.find('.app-event-time').text(timeText);
                                preview.find('.app-event-time-long').text(longTimeText);
                                draggedCalendarEvent.previewDate = date;
                            }
                        }

                    }
                }
                break;
            case 'month':
                var dayCell = target.closest('td'),
                    month = dayCell.closest('.app-calendar-month'),
                    day = dayCell.attr('data-cal-day');

                canDrag = !!day;
                break;
            case 'year':
            case 'agenda':
                return;
        }

        if (canDrag) {
            event.originalEvent.dataTransfer.dropEffect = 'move';
            event.preventDefault();
        }

    })
    .on('drop', '.app-calendar', function (event) {
        if (!draggedCalendarEvent)
            return;

        var target = $(event.target),
            echo = target.closest('.app-echo'),
            dataView = echo.length ? $app.find(echo.attr('data-for')) : touch.dataView(),
            calendar = dataView && dataView.calendar,
            scrollable;

        if (!dataView || !calendar || !dataView._keyFields.length)
            return;

        scrollable = calendar.scrollable();

        var config = calendar && calendar.activeCalendar,
            context = draggedCalendarEvent.context,
            oldStart = context[1],
            newStart,
            oldEnd = context[2],
            newEnd;

        switch (calendar.mode) {
            case 'day':
            case 'week':
                var dropTarget = target.closest('.app-calendar-day,.current-time-line');

                if (dropTarget.length) {
                    newStart = dropTarget.is('.current-time-line') ? dropTarget.data('date') : getDateOfBlock(dropTarget);
                    var oEvent = event.originalEvent,
                        pageY = dragY2PageY(event, scrollable, calendar) - draggedCalendarEvent.offset,
                        hourHeight = dayAndWeekHeight / 25,
                        hourPos = pageY / hourHeight;
                    if (hourPos > 23.75)
                        hourPos = 23.75;
                    else if (hourPos < 0)
                        hourPos = 0;
                    var hour = Math.floor(hourPos),
                        frac = hourPos - hour;

                    setDateFraction(newStart, hour, frac);

                    if (draggedCalendarEvent.mode == 'resize') {
                        newStart.setFullYear(oldStart.getFullYear(), oldStart.getMonth(), oldStart.getDate());
                        newEnd = newStart;
                        newStart = oldStart;

                        var minEnd = new Date(oldStart);
                        minEnd.setMinutes(minEnd.getMinutes() + 30);
                        if (newEnd < minEnd)
                            newEnd = minEnd;
                    }
                }
                break;
            case 'month':
                var dayCell = $(event.target).closest('td'),
                    month = dayCell.closest('.app-calendar-month');

                if (month.length) {
                    newStart = new Date(oldStart);
                    newStart.setYear(month.attr('data-cal-year'));
                    newStart.setMonth(month.attr('data-cal-month'));
                    newStart.setDate(dayCell.attr('data-cal-day'));
                    if (newStart.getDate() == oldStart.getDate() && newStart.getMonth() == oldStart.getMonth())
                        newStart = null;
                }
                break;
            case 'year':
            case 'agenda':
                return;
        }

        if (newStart) {

            var values = [
                    { field: dataView._keyFields[0].Name, value: context[0] },
                    { field: config.date.Name, oldValue: oldStart, newValue: newStart }
            ];

            // shift end time by old/new start difference
            if (oldEnd || newEnd) {
                if (!newEnd) {
                    var difference = oldEnd.getTime() - oldStart.getTime();
                    newEnd = new Date(newStart.getTime() + difference);
                }
                values.push({ field: config.end.Name, oldValue: oldEnd, newValue: newEnd });
            }

            // stop event
            event.preventDefault();
            event.stopPropagation();
            draggedCalendarEvent.dropped = true;

            // execute
            $app.execute({
                command: 'Update',
                controller: dataView._controller,
                view: dataView._viewId,
                values: values,
                success: function () {
                    calendar.lastScrollTop = scrollable.scrollTop();
                    dataView.sync();
                },
                error: function (error) {
                    $app.alert(String.format('{0}', error.get_message()));
                }
            });
        }
    })
    .on('vclick contextmenu taphold', '.app-calendar, .app-bar-calendar', function (event) {
        if (skipClick || draggedCalendarEvent) {
            skipClick = false;
            return;
        }

        var target = $(event.target),
            eventType = event.type,
            echo = target.closest('.app-echo'),
            dataView = echo.length ? $app.find(echo.attr('data-for')) : touch.dataView(),
            calendar = dataView.calendar,
            scrollable = $.mobile.activePage.find('.app-wrapper'),
            presenter = scrollable.find('.app-presenter[data-presenter="calendar"]'),
            button = target.closest('.ui-btn'),
            parent = target.parent(),
            hour = target.attr("data-cal-hour"),
            isLookup,
            lastTouch = touch.lastTouch();

        if (!dataView || !dataView.calendar)
            return;

        isLookup = dataView._lookupInfo;

        if (target.closest('.app-tabs ul').length > 0)
            return;

        if (!button.length)
            button = target.find('.ui-btn');

        // scope to correct target
        if (target.is('ul') && !!parent.attr('data-cal-day')) {
            target = parent;
        }
        else if (parent.is('.app-event'))
            target = parent;
        else if (target.is('.app-tabs')) {
            return false;
            // handle 8 pixel inaccuracy
            var btns = target.find('.ui-btn'),
                x = lastTouch && lastTouch.x || event.clientX,
                result = false;
            btns.each(function () {
                var btn = $(this),
                    left = btn.offset().left;
                if ((left - 8) <= x && x <= (left + btn.outerWidth() + 8)) {
                    btn.trigger('vclick');
                    result = true;
                    return false;
                }
            });
            if (result)
                return false;
        }

        // validate permitted events
        if (eventType == 'taphold' && !target.is('.app-event'))
            return;
        if ((eventType == 'contextmenu') && (!target.is('td,.app-event') && hour == null))
            return;

        var dataContext = target.data('data-context'),
            dataMoreContext = target.data('data-more-context');
        if (target.is('.dv-load-at-top, .dv-load-at-bottom, .app-btn-next, .app-btn-prev')) {
            var blocks = calendar.getBlocks(scrollable),
                testDate,
                year,
                maxRender = echo.length ? 0 : modeMaxRender[calendar.mode],
                handler = calendar.views[calendar.mode];


            // TODO what is this?
            //if ($app.touch.desktop())
            //    $app.touch.stopScrolling(target);

            // load at top
            if (target.is('.dv-load-at-top, .app-btn-prev')) {
                // remove excessive blocks
                if (blocks.length > maxRender) {
                    if (calendar.mode == "agenda")
                        handler.removeData(scrollable.find('.app-calendar-agendaview'), handler.maxPage);
                    else
                        blocks.slice(maxRender).remove();
                }

                var firstPlaceholder = blocks.first(),
                    newPlaceholder,
                    addedHeight = 0,
                    year = Number(firstPlaceholder.data('cal-year')),
                    month = firstPlaceholder.data('cal-month') != null ? Number(firstPlaceholder.data('cal-month')) : 1,
                    testDate = getDateOfBlock(firstPlaceholder),
                    oldScrollTop = scrollable.scrollTop(),
                    topGap = target.outerHeight(true) - scrollable.find('.app-presenter-instruction').outerHeight(true),//-scrollable.find('.app-presenter-instruction').outerHeight(true),//-target.height() - 3, // target.height();// (target.outerHeight(true) + scrollable.find('.app-presenter-instruction').outerHeight(true)); //
                    newContent = [];


                // add blocks to beginning
                for (var drawCount = 0; drawCount < modeDrawDistance[calendar.mode]; drawCount++) {
                    switch (calendar.mode) {
                        case "month":
                            testDate.setMonth(testDate.getMonth() - 1);
                            newPlaceholder = handler.drawMonth(testDate);
                            break;
                        case "year":
                            testDate.setFullYear(year - 1);
                            year = testDate.getFullYear();
                            newPlaceholder = handler.drawYear(testDate);
                            topGap += -6; // negative margin
                            break;
                        case "agenda":
                            target.text(resourcesHeaderFilter.Loading);
                            handler.loadData(scrollable.find('.app-calendar-agendaview'), null, handler.minPage - 1);
                            break;
                    }
                    if (newPlaceholder) {
                        newPlaceholder.insertBefore(firstPlaceholder);
                        firstPlaceholder = newPlaceholder;
                        //addedHeight += newPlaceholder.outerHeight(true);
                        newContent.push(newPlaceholder);
                    }
                }
                handler.resize(calendar.getVisibleView());
                $(newContent).each(function () {
                    addedHeight += $(this).outerHeight(true);
                });
                if (addedHeight)
                    touch.scroll(scrollable, Math.ceil(oldScrollTop + addedHeight + topGap));
            }
                // load at bottom
            else {
                var lastPlaceholder = blocks.last(),
                    newPlaceholder,
                    year = Number(lastPlaceholder.data('cal-year')),
                    month = lastPlaceholder.data('cal-month') != null ? Number(lastPlaceholder.data('cal-month')) : 1,
                    testDate = new Date(year, month);

                // remove excessive years
                if (blocks.length > maxRender) {
                    if (calendar.mode == 'agenda')
                        handler.removeData(scrollable.find('.app-calendar-agendaview'), handler.minPage);
                    else {
                        blocks.slice(0, blocks.length - maxRender).remove();
                        var height = 0;
                        blocks.each(function () {
                            height += $(this).height();
                        });
                        touch.scroll(scrollable, height - 1);
                    }
                }

                // add blocks to end
                for (var drawCount = 0; drawCount < modeDrawDistance[calendar.mode]; drawCount++) {
                    switch (calendar.mode) {
                        case "month":
                            testDate.setMonth(testDate.getMonth() + 1);
                            newPlaceholder = handler.drawMonth(testDate);
                            break;
                        case "year":
                            testDate.setFullYear(year + 1);
                            year = testDate.getFullYear();
                            newPlaceholder = handler.drawYear(testDate);
                            break;
                        case "agenda":
                            target.text(resourcesHeaderFilter.Loading);
                            handler.loadData(scrollable.find('.app-calendar-agendaview'), null, handler.maxPage + 1)
                            break;
                    }
                    if (newPlaceholder) {
                        newPlaceholder.insertAfter(lastPlaceholder);
                        lastPlaceholder = newPlaceholder;
                    }
                }
                handler.resize(calendar.getVisibleView());
            }

            return false;
        }
            // clicked on event
        else if (dataContext) {
            calendar.selectEvent(dataContext, target, event);
            event.preventDefault();
            return false;
        }

            // show event list in day/week
        else if (target.is('.app-event-more')) {
            if (!calendar.hasKeyFields())
                return false;

            var date = getDateOfBlock(target.closest('.app-calendar-day')),
                data = target.data('data-more-context');
            calendar.showEventList(date, data, target, event);
        }

            // show event list in month
        else if (target.closest('.app-calendar-month-more').length) {
            if (!calendar.hasKeyFields())
                return false;

            var moreBtn = target.closest('.app-calendar-month-more'),
                td = target.closest('td'),
                visibleEvents = td.find('.app-event'),
                visibleEventIDs = [],
                month = target.closest('.app-calendar-month'),
                day = td.attr('data-cal-day'),
                startDate = getDateOfBlock(month);
            startDate.setDate(day);

            visibleEvents.each(function () {
                var event = $(this),
                    row = event.data('data-context');
                visibleEventIDs.push(row[0]);
            });

            function showPopup(data, date) {
                data = data.filter(function (event) {
                    return visibleEventIDs.indexOf(event[0]) == -1;
                });

                calendar.showEventList(startDate, data, target, event);
            }

            // show more items in list
            moreBtn.addClass('ui-btn-active');
            touch.callWithFeedback(td, function () {
                moreBtn.removeClass('ui-btn-active');

                var data = td.data('data-more-context');
                if (!data) {

                    // fetch and parse data
                    calendar.requestData({
                        mode: 'daylist',
                        date: startDate,
                        success: function (result) {
                            if (result.Pivots.pivot0 && result.Pivots.pivot0.Data[1]) {
                                data = result.Pivots.pivot0.Data[1][1];

                                td.data('data-more-context', data);
                                showPopup(data);
                            }
                        }
                    });
                }
                else
                    showPopup(data);
            });
        }
            // day header to scroll to day
        else if (target.closest('.app-day-header').length) {
            if (target.is('ul'))
                return;

            var view = presenter.find('.app-calendar-dayview'),
                header = button.closest('.app-day-header'),
                footer = presenter.data('cal-footer');

            touch.callWithFeedback(button, function () {
                var outer = presenter.data('cal-footer').find('.app-scroll-outer'),
                    parent = button.closest('li'),
                    date = getDateOfBlock(parent),
                    year = date.getFullYear(),
                    month = date.getMonth(),
                    day = date.getDate(),
                    column = calendar.getBlockByDate(view, date, 'day'),
                    left = parseInt(view.css('marginLeft'), 10) - column.position().left;
                if (column.length)
                    calendar.views.day._scroll(view, header, left * -1, footer, true);
            });
            return false;
        }
            // week header click to open day
        else if (target.closest('.app-week-header').length) {
            if (target.is('ul'))
                return;

            touch.callWithFeedback(button, function () {
                var link = findTab(target.closest('.app-bar-calendar'), resourcesCalendar.Day),
                    date = getDateOfBlock(button.closest('li'));
                calendar.navigateDate = date;
                if (link)
                    link.trigger('vclick');
            });
            return false;
        }
            // buttons
        else if (target.is('.ui-btn') || target.closest('.ui-btn').length) {
            // go to today
            if (button.is('.app-calendar-today,.app-calendar-next,.app-calendar-prev')) {
                touch.callWithFeedback(button, function () {
                    if (scrollable.length > 0) {

                        var goNext = button.is('.app-calendar-next'),
                            goPrev = button.is('.app-calendar-prev'),
                            mode = 'today';

                        if (goNext)
                            mode = 'next';
                        else if (goPrev)
                            mode = 'prev';

                        calendar.scrollView(mode);
                    }
                });
                return false;
            }
                // show badge menu
            else if (button.is('.app-calendar-badge')) {
                var config = dataView.viewProp('calendarConfig'),
                    mode = config.mode,
                    tabs = scrollable.parent().find('.app-bar-calendar .app-tabs');

                if (tabs.css('visibility') == 'hidden') {
                    // open popup
                    touch.callWithFeedback(button, function () {
                        touch.listPopup({
                            anchor: button,
                            iconPos: 'left',
                            items: [
                                { text: resourcesCalendar.Day, icon: mode == 'day' ? 'check' : false, callback: clickOnCalendarTab },
                                { text: resourcesCalendar.Week, icon: mode == 'week' ? 'check' : false, callback: clickOnCalendarTab },
                                { text: resourcesCalendar.Month, icon: mode == 'month' ? 'check' : false, callback: clickOnCalendarTab },
                                { text: resourcesCalendar.Year, icon: mode == 'year' ? 'check' : false, callback: clickOnCalendarTab },
                                { text: resourcesCalendar.Agenda, icon: mode == 'agenda' ? 'check' : false, callback: clickOnCalendarTab }
                            ]
                        });
                    });
                }
                else {
                    touch.callWithFeedback(button, function () {
                        touch.listPopup({
                            anchor: button,
                            title: button.attr('title')
                        });
                    });
                }
            }
                //go to month 
            else if (button.is('.app-calendar-month-header')) {
                var date,
                    header = presenter.data('cal-header'),
                    link = findTab(header, resourcesCalendar.Month);

                switch (calendar.mode) {
                    case 'year':
                        var year = target.closest('.app-calendar-year').attr('data-cal-year'),
                            month = target.closest('.app-calendar-month').attr('data-cal-month');
                        date = new Date(year, month);
                        break;
                    case 'agenda':
                        date = getDateOfBlock(button);
                        break;
                }
                if (date) {
                    calendar.navigateDate = date;
                    touch.callWithFeedback(button, function () {
                        if (link)
                            link.trigger('vclick');
                    });
                    return false;
                }
            }
            else if (button.parent().attr('data-cal-day') || target.is('h2')) {
                if (calendar.mode == "month") {
                    var month = target.closest('.app-calendar-month'),
                        header = presenter.data('cal-header'),
                        link = findTab(header, resourcesCalendar.Day),
                        date = getDateOfBlock(month);
                    if (target.is('td'))
                        return;
                    date.setDate(button.parent().attr('data-cal-day'));
                    calendar.navigateDate = date;
                    touch.callWithFeedback(button, function () {
                        if (link)
                            link.trigger('vclick');
                    });
                    return false;
                }
                else if (calendar.mode == 'agenda' && !echo.length) {
                    var date = getDateOfBlock(target.closest('li')),
                        header = presenter.data('cal-header'),
                        link = findTab(header, resourcesCalendar.Day);
                    if (date) {
                        calendar.navigateDate = date;
                        touch.callWithFeedback(button, function () {
                            if (link)
                                link.trigger('vclick');
                        });
                    }
                }
            }
        }
            // table click
        else if (target.is('td') || (target.is('div') && hour != null)) {
            if (calendar.mode == "year") {
                if (target.height() < 20 && !isNotTouch())
                    target.closest('.app-calendar-month').find('.app-calendar-month-header').trigger('vclick');
                else {
                    var day = parseInt(target.text());
                    if (!day)
                        return;
                    var year = target.closest('.app-calendar-year').attr('data-cal-year'),
                        month = target.closest('.app-calendar-month').attr('data-cal-month'),
                        header = presenter.data('cal-header'),
                        link = findTab(header, resourcesCalendar.Day),
                        date = new Date(year, month, day);
                    calendar.navigateDate = date;
                    target.addClass('ui-btn-active');
                    touch.callWithFeedback(target, function () {
                        if (link)
                            link.trigger('vclick');
                        target.removeClass('ui-btn-active');
                    });
                }
                return false;
            }
                // trigger "New" action
            else {
                var context = [],
                    newActions = calendar.getActionsByName('New'),
                    date, endDate,
                    calendarContainer = $('.app-calendar'),
                    config = calendar.activeCalendar,
                    hasEnd = !!config.end,
                    isMonth = calendar.mode == 'month',
                    preview;

                if (!newActions.length)
                    return;

                if (isMonth) {
                    var day = target.attr('data-cal-day'),
                        month = target.closest('div.app-calendar-month');
                    if (!day)
                        return;
                    date = getDateOfBlock(month);
                    date.setDate(day);

                    if (hasEnd) {
                        endDate = new Date(date);
                        endDate.setMinutes(endDate.getMinutes() + 60);
                    }
                }
                else { // mode == day || week
                    var day = target.closest('div.app-calendar-day'),
                        dayList = day.find('.app-calendar-eventlist'),
                        y = event.clientY - target.offset().top,
                        height = target.height(),
                        frac = y / height;
                    date = getDateOfBlock(day);
                    setDateFraction(date, hour, frac);

                    if (hasEnd) {
                        endDate = new Date(date);
                        endDate.setMinutes(endDate.getMinutes() + 60);
                    }

                    preview = calendar.drawEvent([null, date, endDate, null, ' '], null).removeClass('app-event-color-0').addClass('app-event-new');

                    if (hasEnd)
                        preview.height(dayAndWeekHeight / 25);

                    var top = drawTime(date, 'find');
                    preview.css('top', top + 22).appendTo(dayList);
                }

                if (!date)
                    return;

                newActions.forEach(function (action) {
                    var oldCallback = action.callback;
                    action.callback = function (arguments) {
                        $app.newValues = [{ name: config.date.Name, value: date }];
                        if (hasEnd)
                            $app.newValues.push({ name: config.end.Name, value: endDate });
                        oldCallback(arguments);
                    }
                });

                var options = {
                    iconPos: 'left',
                    items: newActions,
                    title: String.format('{0:' + dtf.LongDatePattern + '} {0:' + dtf.ShortTimePattern + '}', date),
                    afterclose: function () {
                        if (preview)
                            preview.remove();
                    }
                };

                if (isMonth)
                    options.anchor = target;
                else {
                    options.x = event.pageX;
                    options.y = event.pageY;
                    options.arrow = 'b,t,l,r';
                }

                // open popup
                touch.listPopup(options);
                return false;
            }
        }
    })
    // clear selection
    .on('clear.dataview.app', function (event) {
        var dataView = event.dataView,
            calendar = dataView.calendar;
        if (calendar)
            $('#' + dataView._id).find('.app-calendar-selected').removeClass('app-calendar-selected');
    })
    // refresh the data if the filter has changed
    .on('reset.dataview.app', function (event) {
        var dataView = event.dataView;

        if (!dataView)
            return;

        var calendar = dataView.calendar,
            viewStyle = dataView && dataView.extension() && dataView.extension().viewStyle(),
            plugin = dataView.calendarPlugin;

        if (calendar) {
            calendar.clear();
            calendar.activeCalendar.colorMap.clearFilter();

            //if (viewStyle != 'calendar') {
            //    // clear filter
            //    calendar.gridFilter = dataView.get_filter();
            //    dataView.removeFromFilter(calendar.activeCalendar.date);
            //}
            //else {
            //    // restore filter
            //    if (calendar.gridFilter)
            //        dataView.set_filter(calendar.gridFilter);
            //}
        }

        if (plugin) {
            var viewType = dataView && dataView.get_viewType(dataView._id),
                master = dataView.get_master();
            //filter = dataView.combinedFilter(),
            //lastFilter = plugin.lastFilter || [],
            //filterChanged = plugin.filterWithoutField(filter) != plugin.filterWithoutField(lastFilter),
            //dateFilterChanged = (filter.length != lastFilter.length || filter.join() != lastFilter.join()) && !plugin.filtering;

            // skip child view refresh
            if (master && !dataView.get_selectedKey().length)
                return;

            if (viewType && viewType == 'Grid') {
                if (!plugin.filtering) {
                    plugin.clearCache();
                    touch.stickyHeaderBar().hide();
                }
                //if (filterChanged) {
                //    plugin.clearCache();
                //    touch.stickyHeaderBar().hide();
                //}
                //else if (dateFilterChanged)
                //    plugin.refresh();
            }
        }
    })

    // show or hide the calendar plugin depending on active dataView
    .on('show.dataview.app', function (event) {
        var dataView = event.dataView,
            viewType = dataView && dataView.get_viewType(dataView._id),
            sidebar = touch.sidebar();

        if (!dataView || viewType != 'Grid') {
            detachPlugin(sidebar);
            return;
        }

        if (!supportsCalendar(dataView))
            return;

        else if (viewType && viewType == 'Grid') {
            if (dataView.calendar)
                dataView.calendar.loadData(dataView.calendar.getVisibleView());
            if (dataView.calendarPlugin)
                dataView.calendarPlugin.attach(sidebar);

        }

    });


    var Calendar = function (dataView, calendars) {
        var that = this;
        that.dataView = dataView;
        var config = dataView.viewProp('calendarConfig') || {};
        if (!config.mode)
            config.mode = $(document).width() < 768 ? 'day' : 'week';
        that.mode = config.mode;
        that.calendars = calendars;
        if (config.activeCalendar)
            $(calendars).each(function () {
                if (this.name == config.activeCalendar) {
                    that.activeCalendar = this;
                    return false;
                }
            });
        if (!that.activeCalendar)
            that.activeCalendar = calendars[Object.keys(calendars)[0]];
        that.cache = new Cache(that);
        that.views = {
            day: new Day(that),
            week: new Week(that),
            month: new Month(that),
            year: new Year(that),
            agenda: new Agenda(that)
        }
        dataView.viewProp('calendarConfig', config);
    }

    Calendar.prototype = {
        scrollable: function () {
            var that = this,
                scrollable = that._scrollable;
            if (!scrollable)
                scrollable = that._scrollable = $('#' + this.dataView._id + ' .app-wrapper');
            return scrollable;
        },
        viewClassName: function () {
            return String.format('.app-calendar-{0}view', this.mode);
        },
        show: function (options) {
            var that = this,
                dataView = this.dataView,
                filter = dataView._filter,
                taggedFields = [],
                isEcho = options.container.closest('.app-echo').length > 0,
                calendar = options.container.find('.app-calendar'),
                scrollable = options.container.closest('.app-wrapper'),
                pivots = options.container.data('pivots'),
                calendars = this.calendars,
                config = dataView.viewProp('calendarConfig'),
                colorMap = this.activeCalendar.colorMap,
                header,
                headerTabs,
                badge,
                footer,
                navigateBlock;

            if ($.isEmptyObject(calendars))
                return;

            if (!isEcho && this.lastScrollTop && scrollable.scrollTop() == 0)
                touch.scroll(scrollable, this.lastScrollTop);

            if (isEcho) {
                this.mode = 'agenda';
                this.echoMaxHeight = options.maxHeight;
                config.mode = 'agenda';
                dataView.viewProp('calendarConfig', config)
            }
            else if (config.mode)
                this.mode = config.mode;
            var viewHandler = this.getViewHandler();

            // get selected record date
            if (!this.navigateDate && !this.preventNavigate) {
                var row = dataView.extension().commandRow();
                if (row && this.activeCalendar.date) {
                    this.enhancePrecision = true;
                    this.navigateDate = row[this.activeCalendar.date.Index];
                }

                else
                    this.navigateDate = new Date();
            }


            if (calendar.length > 0) {
                // calendar exists, show it
                var view = options.container.find('.app-calendar > div:visible');
                if (!isEcho) {
                    header = options.container.data('cal-header');
                    footer = options.container.data('cal-footer');

                    viewHandler.showHeaderAndFooter(header, footer);
                    $app.touch.bar('show', header);

                    colorMap.show();


                    if (view.is(that.viewClassName())) {
                        if (this.navigateDate && !this.preventNavigate) {
                            navigateBlock = this.getBlockByDate(view, this.navigateDate);
                            // if found, scroll to
                            if (navigateBlock && navigateBlock.length && !isEcho) {
                                this.scroll({ view: view, enhancePrecision: true });
                                return;
                            }
                            this.animate = false;
                        }
                    }
                    else
                        view.hide();
                }


            }
            else {

                // first time setup 
                calendar = $('<div class="app-calendar"></div>').appendTo(options.container);

                if (!isEcho) {
                    // create a tab bar in the fixed header
                    header = $('<div class="app-bar-calendar"></div>').appendTo($app.touch.bar('create', {
                        type: 'header', page: options.container
                    }));
                    // create "current year/year+month" indicator in the tab bar
                    badge = $('<div class="app-calendar-badge ui-btn"></div>').appendTo(header);

                    // create tabs in the tab bar
                    $app.touch.tabs('create', {
                        container: $('<div class="app-tabs"></div>').appendTo(header),
                        tabs: [
                            { text: resourcesCalendar.Day, value: 'day', selected: this.mode == 'day' },
                            { text: resourcesCalendar.Week, value: 'week', selected: this.mode == 'week' },
                            { text: resourcesCalendar.Month, value: 'month', selected: this.mode == 'month' },
                            { text: resourcesCalendar.Year, value: 'year', selected: this.mode == 'year' },
                            { text: resourcesCalendar.Agenda, value: 'agenda', selected: this.mode == 'agenda' }
                        ],
                        change: function (tab) {
                            var oldMode = that.mode,
                                mostVisibleBlock = that.getMostVisibleBlock(scrollable, oldMode),
                                mostVisibleDate = mostVisibleBlock && getDateOfBlock(mostVisibleBlock),
                                useOldDate = false,
                                config = dataView.viewProp('calendarConfig'),
                                plugin = dataView.calendarPlugin;
                            config.mode = tab.value;
                            dataView.viewProp('calendarConfig', config);
                            // preserve month/day
                            if (!that.navigateDate) {
                                if (that.lastDate)
                                    switch (oldMode) {
                                        case 'year':
                                            if (that.lastDate.getFullYear() == mostVisibleDate.getFullYear())
                                                useOldDate = true;
                                            break;
                                        case 'month':
                                            if (that.lastDate.getFullYear() == mostVisibleDate.getFullYear() && that.lastDate.getMonth() == mostVisibleDate.getMonth())
                                                useOldDate = true;
                                            break;
                                    }
                                that.navigateDate = useOldDate ? that.lastDate : mostVisibleDate;
                                that.enhancePrecision = true;
                            }
                            if (oldMode.match(/week|day/))
                                that.lastDayScrollTop = scrollable.scrollTop();
                            options.container = options.container.closest('.app-wrapper');
                            options.container.focus();

                            if (that.navigateDate && isNaN(that.navigateDate.getTime())) {
                                alert('navigate date is NaN');
                                that.navigateDate = new Date();
                            }
                            touch.presenter('show', options);
                            if (plugin)
                                plugin.refresh();
                        },
                        restoreScrolling: false,
                        stickyHeader: true
                    });
                    // save calendar header for future reference
                    options.container.data('cal-header', header);

                    // create Previous and Next buttons
                    $('<a class="ui-btn ui-btn-icon-notext ui-icon-carat-l ui-corner-all app-calendar-prev"></a>').attr('title', resourcesPager.Previous).appendTo(header);
                    $('<a class="ui-btn ui-btn-icon-notext ui-icon-carat-r ui-corner-all app-calendar-next"></a>').attr('title', resourcesPager.Next).appendTo(header);
                    // create "Today" button
                    var todayButton = $('<a class="ui-btn ui-btn-icon-notext ui-icon-calendar ui-corner-all app-calendar-today"></a>').attr('title', resourcesCalendar.Today);
                    todayButton.appendTo(header);
                    // create a footer bar
                    footer = $('<div class="app-bar-calendar-footer"> </div>').appendTo($app.touch.bar('create', {
                        type: 'footer', page: options.container
                    }));
                    var outer = $('<div class="app-scroll-outer"></div>').insertBefore(footer.contents().first()),
                        inner = $('<div class="app-scroll-inner"></div>').appendTo(outer);

                    outer.on('scroll', function (event) {
                        //return
                        // Attention: do not skip scroll events here

                        if (outer.data('resizing')) {
                            outer.removeData('resizing');
                            return;
                        }

                        var mode = that.mode;

                        if (mode.match(/day|week/)) {
                            var sl = outer.scrollLeft(),
                                viewClass = that.viewClassName(),
                                headerClass = '.app-' + mode + '-header'
                            //touch.callInAnimationFrame(function () {
                            that.views[mode]._scroll(scrollable.find(viewClass), header.find(headerClass), sl, footer);
                            //});
                        }
                    });

                    if (this.mode.match(/day|week/))
                        $app.touch.bar('show', footer);

                    // save calendar header for future reference
                    options.container.data('cal-footer', footer);

                    startDrawTime();
                }
            }


            if (this.activeCalendar.end)
                calendar.addClass('app-calendar-has-end-time');
            else
                calendar.removeClass('app-calendar-has-end-time');

            var viewClass = String.format('app-calendar-{0}view', this.mode),
                headerClass = String.format('.app-{0}-header', this.mode),
                view = calendar.find('.' + viewClass),
                viewHeader = isEcho ? null : header.find(headerClass);

            if (this.navigateDate && !this.preventNavigate)
                navigateBlock = this.getBlockByDate(view, this.navigateDate);

            if (view.length > 0 && (this.preventNavigate || (this.navigateDate && navigateBlock && navigateBlock.length))) {
                ///
                // Show View
                ///
                if (!view.is(':visible'))
                    view.fadeIn();
                viewHandler.resize(view, viewHeader, footer);
            }
            else {
                ///
                // Draw View
                ///
                view = viewHandler.draw(calendar, this.navigateDate);
            }

            if (!isEcho) {
                // refresh the bar that owns the header for the calendar
                $app.touch.bar('show', header);
                that.updateHeader(header);
            }
            this.resetVars();
        },
        scroll: function (options) {
            if (!options.view)
                options.view = this.getVisibleView();
            if (options.preventNavigate == null)
                options.preventNavigate = this.preventNavigate;
            if (options.enhancePrecision == null)
                options.enhancePrecision = this.enhancePrecision;
            if (options.animate == null)
                options.animate = this.animate;
            if (options.date == null)
                options.date = this.navigateDate;
            this.getViewHandler().scroll(options);
            this.resetVars();
        },
        hide: function (options) {
            var dataView = touch.dataView(),
                viewStyle = dataView && dataView.extension().viewStyle(),
                scrollable = this.scrollable();

            if (scrollable)
                this.lastScrollTop = scrollable.scrollTop();

            // skip hide/show sequence
            if (viewStyle == "calendar")
                return;

            var header = options.container.data('cal-header'),
                footer = options.container.data('cal-footer'),
                sidebar = touch.sidebar(),
                legend = sidebar.find('.app-calendar-color-legend'),
                scrollable = this.scrollable(),
                presenter = scrollable.find('.app-presenter[data-presenter="calendar"]');
            if (header)
                $app.touch.bar('hide', header);
            if (footer)
                $app.touch.bar('hide', footer);
            this.dataView.calendarPlugin.refresh();
            this.activeCalendar.colorMap.hide();
        },
        dispose: function (options) {
            // dispose header
            var header = options.container.data('cal-header'),
                dataView = this.dataView;
            if (!!header) {
                header.off();
                $app.touch.tabs('destroy', {
                    container: header
                });
                $app.touch.bar('remove', header);
            }
            // dispose footer
            var footer = options.container.data('cal-footer')
            if (footer) {
                footer.off();
                $app.touch.bar('remove', footer);
            }
            // clear data references
            options.container.removeData();
            // stop timeouts
            clearInterval(drawTimeInterval);
            // clear cache
            this.cache.clear(options.container);
            dataView.calendar.activeCalendar.colorMap.clearFilter();

            // delete references
            for (var view in this.views)
                this.views[view].calendar = null;
            dataView.calendar = null;
            dataView.calendarPlugin.calendar = null;
            dataView.calendarPlugin.dataView = null;
            dataView.calendarPlugin = null;
            this.dataView = null;
            this._scrollable = null;
        },
        selectEvent: function (context, target, event) {
            var eventType = event.type,
                ctrlKey = event.ctrlKey,
                x = event.pageX,
                y = event.pageY,
                scrollable = this.scrollable(),
                calendar = this,
                dataView = calendar.dataView,
                isLookup = dataView._lookupInfo,
                isEcho = target.closest('.app-echo').length;

            if (!this.hasKeyFields())
                return;

            var keyField = this.dataView._keyFields[0],
                key = this.getCurrentKey(),
                contextKey = this.mode != 'agenda' && !isEcho ? context[0] : context[keyField.Name],
                echo = $('#' + dataView._id + '_echo');


            function handleClick(selected) {
                var handled = false,
                    isClicked = target.is('.app-calendar-selected'),
                    pageInfo = touch.pageInfo(dataView._id);
                skipClick = eventType == 'taphold';
                if (!isEcho)
                    pageInfo.echoChanged = true;
                if (skipClick || eventType == 'vclick' && ctrlKey) {
                    // handle taphold
                    handled = true;
                    if (selected) {
                        target.removeClass('app-calendar-selected');
                        dataView.extension().clearSelection();
                    }
                }
                else if (eventType == 'contextmenu') {
                    // show context menu
                    touch.contextScope(dataView._id);
                    touch.rowContext(target, {
                        x: x, y: y
                    });
                    touch.contextScope(null);
                    handled = true;
                }
                touch.refreshEchoToolbarWithDelay(dataView, echo);
                if (!handled) {
                    touch.contextScope(dataView._id);
                    touch.cardPopup({
                        anchor: target,
                        x: x,
                        y: y,
                        dataView: dataView
                    });
                    touch.contextScope(null);
                }
            }

            function selectRow(row) {
                dataView.extension().tap({ row: row }, isLookup ? 'select' : 'none');
                // deselect
                scrollable.find('.app-calendar-selected').removeClass('app-calendar-selected');
                echo.find('.app-calendar-selected').removeClass('app-calendar-selected');

                function findSelectEvent(event) {
                    var context = event.data('data-context');
                    if (context && context[keyField.Name] == contextKey) {
                        event.addClass('app-calendar-selected');
                        return false;
                    }
                }

                // select in view
                if (isEcho)
                    scrollable.find(calendar.viewClassName() + ' .app-event').each(function () {
                        findSelectEvent($(this));
                    });

                else
                    target.closest('.app-event, .app-calendar-month-more').addClass('app-calendar-selected');

                // select in echo
                if (echo.length)
                    echo.find('.app-event').each(function () {
                        findSelectEvent($(this));
                    });

                if (!isLookup) {
                    //dataView.raiseSelected();
                    //touch.pageInfo(dataView._id).echoChanged = true;
                    handleClick(false);
                    touch.refreshEchoToolbarWithDelay(dataView, echo);
                }
            }

            if (dataView._keyFields.length == 1) {
                if (draggedCalendarEvent) return;
                touch.clearHtmlSelection();
                if (key != null && contextKey == key)
                    handleClick(true);
                else {
                    if (calendar.mode == "agenda") {
                        selectRow(context);
                    }
                    else
                        $app.execute({
                            controller: dataView._controller,
                            view: dataView._viewId,
                            filter: [{ field: keyField.Name, operator: '=', value: context[0] }],
                            sort: '',
                            success: function (result) {
                                if (draggedCalendarEvent) return;
                                selectRow(result[dataView._controller][0]);
                            },
                            error: function (error) {
                                $app.alert(String.format('{0}', error.get_message()));
                            }
                        });
                }
                target.addClass('ui-btn-active');
                touch.callWithFeedback(target, function () {
                    target.removeClass('ui-btn-active');
                });
            }
        },
        showEventList: function (startDate, data, target, event) {
            var calendar = this,
                key = calendar.getCurrentKey(),
                items = [];
            // foreach row, add list item
            data.forEach(function (row) {
                var id = row[0],
                    start = row[1],
                    end = row[2],
                    color = row[3],
                    text = row[4];
                items.push({
                    text: calendar.getEventTitle(start, end, text, ''),
                    color: calendar.activeCalendar.colorMap.color(row[3]),
                    visible: id == key ? true : false,
                    callback: function () {
                        calendar.selectEvent(row, target, event);
                    }
                });
            });

            // show list popup
            touch.listPopup({
                title: String.format('{0:' + dtf.LongDatePattern + '}', startDate),
                anchor: target,
                iconPos: 'left',
                items: items
            });
        },
        getViews: function () {
            return $('#' + this.dataView._id).find('.app-wrapper .app-presenter[data-presenter="calendar"] > div.app-calendar > div');
        },
        getVisibleView: function () {
            return this.scrollable().find('.app-presenter[data-presenter="calendar"] > div.app-calendar > div:visible');
        },
        getViewHandler: function () {
            return this.views[this.mode];
        },
        // reset this variables
        resetVars: function () {
            this.preventNavigate = null;
            this.lastDate = this.navigateDate;
            this.navigateDate = null;
            this.enhancePrecision = null;
            this.animate = null;
        },
        clear: function (emptyView) {
            var handler = this.getViewHandler(),
                visibleView = this.getVisibleView();

            this.cache.clear();
            handler.clear(emptyView);
            if (visibleView && visibleView.length) {
                this.loadData(visibleView);
                if (this.dataView.calendarPlugin)
                    this.dataView.calendarPlugin.clearCache();
            }
        },
        // draws a column for day and week views
        drawDayColumns: function (startDate, distance, showTime) {
            var grid = '',
                testDate = new Date(startDate.getFullYear(), startDate.getMonth(), startDate.getDate());

            for (var day = 0; day < distance; day++) {
                var dayBlock = '<div'
                    + ' data-cal-year="' + testDate.getFullYear() + '"'
                    + ' data-cal-month="' + testDate.getMonth() + '"'
                    + ' data-cal-day="' + testDate.getDate() + '" class="app-calendar-day';

                if (isToday(testDate))
                    dayBlock += ' current-day-column';
                if (dtfDayOfWeek[testDate.getDay()] == 6)
                    dayBlock += ' endofweek';

                dayBlock += '">';
                var innerHTML = '';

                if (showTime)
                    innerHTML += this.drawTimeColumn(startDate);

                innerHTML += '<div data-cal-hour="0"></div><div data-cal-hour="0"></div>' +
                    '<div data-cal-hour="1"></div><div data-cal-hour="2"></div>' +
                    '<div data-cal-hour="3"></div><div data-cal-hour="4"></div>' +
                    '<div data-cal-hour="5"></div><div data-cal-hour="6"></div>' +
                    '<div data-cal-hour="7"></div><div data-cal-hour="8"></div>' +
                    '<div data-cal-hour="9"></div><div data-cal-hour="10"></div>' +
                    '<div data-cal-hour="11"></div><div data-cal-hour="12"></div>' +
                    '<div data-cal-hour="13"></div><div data-cal-hour="14"></div>' +
                    '<div data-cal-hour="15"></div><div data-cal-hour="16"></div>' +
                    '<div data-cal-hour="17"></div><div data-cal-hour="18"></div>' +
                    '<div data-cal-hour="19"></div><div data-cal-hour="20"></div>' +
                    '<div data-cal-hour="21"></div><div data-cal-hour="22"></div>' +
                    '<div data-cal-hour="23"></div><div data-cal-hour="0"></div>' +
                    '<ul class="app-calendar-eventlist"></ul><div class="app-clear-fix"></div>';

                dayBlock += innerHTML + '</div>';

                grid += dayBlock;

                testDate.setDate(testDate.getDate() + 1);
            }
            return grid;
        },
        // draws a horizontally scrollable day headers for day and week
        drawDayHeaders: function (startDate, distance) {
            var dayHeaderList = '',
                testDate = new Date(startDate.getFullYear(), startDate.getMonth(), startDate.getDate());
            for (var i = 0; i < distance; i++) {
                var day = dtfDayOfWeek[testDate.getDay()],
                    dayName = dtf.DayNames[testDate.getDay()],
                    abbrDayName = dtf.AbbreviatedDayNames[testDate.getDay()];

                dayHeaderList += '<li '
                    + ' data-cal-year="' + testDate.getFullYear() + '"'
                    + ' data-cal-month="' + testDate.getMonth() + '"'
                    + ' data-cal-day="' + testDate.getDate() + '" class="';
                if (day == 0)
                    dayHeaderList += ' first-day-of-week';
                if (day == 6)
                    dayHeaderList += ' last-day-of-week';
                dayHeaderList += '"><a class="ui-btn" title="' + dayName + '"><span class="letter-day">' + abbrDayName.substring(0, 1)
                    + '</span><span class="abbr-day">' + abbrDayName
                    + '</span><span class="full-day">' + dayName + '</span>&nbsp;<div';

                if (isToday(testDate))
                    dayHeaderList += ' class="app-current-day"';
                dayHeaderList += '>' + testDate.getDate() + '</div></a></li>';

                // increment day
                testDate.setDate(testDate.getDate() + 1);
            }
            return dayHeaderList;
        },
        // draws a vertical colunn of time from 12am-12am
        drawTimeColumn: function (startDate) {
            var timeCol = '<div class="app-calendar-time"><ul>',
                timeStr,
                usesAMPM = !!dtf.AMDesignator.length;

            for (var hour = 0; hour <= 24; hour++) {
                if (usesAMPM) {
                    if (hour == 12)
                        timeStr = resourcesCalendar.Noon;
                    else {
                        var hourStr = hour % 12,
                            designator = hour < 12 ? dtf.AMDesignator : dtf.PMDesignator;
                        if (hour == 0 || hour == 24) {
                            hourStr = 12;
                            designator = dtf.AMDesignator;
                        }
                        timeStr = String.format('{0} {1}', hourStr, designator);
                    }
                }
                else
                    timeStr = hour == 24 ? 0 : hour;
                timeCol += '<li><span data-cal-hour="' + hour + '">' + timeStr + '</span></li>';
            }

            return timeCol += '</ul><div class="app-current-time"></div></div>';
        },
        // get columns or rows of current view
        getBlocks: function (scrollable) {
            return this.getViewHandler().getBlocks();
        },
        // gets the first FULLY visible column or row on screen
        getMostVisibleBlock: function (scrollable) {
            if (!scrollable)
                scrollable = this.scrollable();
            var firstVisibleBlock,
                threshold = scrollable.height() / 2,
                blocks = $(this.getBlocks(scrollable));
            switch (this.mode) {
                case "day":
                case "week":
                    // find horizontal block
                    blocks.each(function () {
                        var block = $(this);
                        if (!firstVisibleBlock)
                            firstVisibleBlock = block;
                        if (block.position().left > block.width() / 2)
                            return false;
                        firstVisibleBlock = block;
                    });
                    if (this.mode == "week")
                        while (firstVisibleBlock && firstVisibleBlock.length && firstVisibleBlock.position().left + firstVisibleBlock.width() <= weekTimeWidth) {
                            var next = firstVisibleBlock.next();
                            firstVisibleBlock = next;
                        }
                    break;
                case "year":
                case "month":
                case "agenda":
                    // find first visible vertical block
                    blocks.each(function () {
                        var block = $(this);
                        firstVisibleBlock = block;
                        if (block.offset().top + block.height() > threshold)
                            return false;
                    });
                    break;
            }
            return firstVisibleBlock;
        },
        // gets the first visible column or row on screen
        getFirstVisibleBlock: function (scrollable) {
            if (!scrollable)
                scrollable = this.scrollable();
            var firstVisibleBlock,
                headerHeight = touch.stickyHeaderBar().outerHeight() + scrollable.offset().top, // TODO
                blocks = $(this.getBlocks(scrollable));
            switch (this.mode) {
                case "day":
                case "week":
                    // find horizontal block
                    blocks.each(function () {
                        var block = $(this);
                        if (!firstVisibleBlock)
                            firstVisibleBlock = block;
                        if (block.position().left > block.width() / 2)
                            return false;
                        firstVisibleBlock = block;
                    });

                    if (this.mode == "week" && firstVisibleBlock && firstVisibleBlock.position().left < 0) {
                        var next = firstVisibleBlock.next();
                        if (next.length)
                            firstVisibleBlock = next;
                    }
                    break;
                case "month":
                case "year":
                case "agenda":
                    // find first visible vertical block
                    blocks.each(function () {
                        var block = $(this);
                        if (!firstVisibleBlock)
                            firstVisibleBlock = block;
                        if (block.offset().top > headerHeight)
                            return false;
                        firstVisibleBlock = block;
                    });
                    break;
            }
            return firstVisibleBlock;
        },
        // gets the last visible column or row on screen
        getLastVisibleBlock: function (scrollable) {
            var firstVisibleBlock,
                viewHeight = scrollable.height() + scrollable.position().top,
                viewWidth = scrollable.width(),
                blocks = $(this.getBlocks(scrollable));
            switch (this.mode) {
                case "day":
                case "week":
                    // find horizontal block
                    blocks.each(function () {
                        var block = $(this);
                        if (!firstVisibleBlock)
                            firstVisibleBlock = block;
                        if (block.position().left >= viewWidth)
                            return false;
                        firstVisibleBlock = block;
                    });
                    break;
                case "month":
                case "year":
                case "agenda":
                    // find first visible vertical block
                    blocks.each(function () {
                        var block = $(this);
                        if (!firstVisibleBlock)
                            firstVisibleBlock = block;
                        if (block.offset().top > viewHeight)
                            return false;
                        firstVisibleBlock = block;
                    });
                    break;
            }
            return firstVisibleBlock;
        },
        // finds an element by the date
        getBlockByDate: function (view, date) {
            var year = date.getFullYear(),
                month = date.getMonth(),
                day = date.getDate();

            if (!view || !view.length)
                return null;

            switch (this.mode) {
                case 'year':
                    return view.find(String.format('.app-calendar-year[data-cal-year="{0}"]', year));
                    break;
                case 'month':
                    return view.find(String.format('.app-calendar-month[data-cal-year="{0}"][data-cal-month="{1}"]', year, month));
                case 'week':
                case 'day':
                    return view.find(String.format('.app-calendar-day[data-cal-year="{0}"][data-cal-month="{1}"][data-cal-day="{2}"]', year, month, day));
                case 'agenda':
                    return view.find(String.format('li[data-cal-year="{0}"][data-cal-month="{1}"][data-cal-day="{2}"] ul', year, month, day));
            }
        },
        // set width and scrollLeft of scroller
        // footer = app-scroll-inner
        resizeScroller: function (view, footer, width) {
            var outer = footer.find('.app-scroll-outer'),
                scrollLeft = parseInt(view.css('marginLeft'), 10) * -1;
            if (width)
                outer.find('.app-scroll-inner').css('width', width);
            outer.scrollLeft(scrollLeft).data('resizing', true);
        },
        // refreshes the header depending on most visible column or row
        updateHeader: function (header) {
            var that = this;
            var scrollable = that.scrollable(),
                mode = that.mode,
                appTabs = header.find('.app-tabs'),
                tabVisible = appTabs.css('visibility') != 'hidden',
                topPlaceholder = that.getFirstVisibleBlock(scrollable);
            if (!topPlaceholder)
                return;

            var badge = header.find('.app-calendar-badge'),
                date = getDateOfBlock(topPlaceholder),
                year = date.getFullYear(),
                month = date.getMonth(),
                day = date.getDay(),
                dayNum = date.getDate(),
                monthName = dtf.MonthNames[month],
                abbrMonthName = dtf.AbbreviatedMonthNames[month],
                space = tabVisible ? appTabs.find('ul').offset().left - badge.offset().left : header.find('a.app-calendar-today').offset().left,
                index = 1,
                badges = [];

            switch (mode) {
                case 'year':
                    badges = ['<b>' + year + '</b>&nbsp;'];

                    // hide same date header
                    var topHeader = topPlaceholder.find('h1');

                    if (!topHeader.is('app-in-header')) {
                        scrollable.find('.app-calendar-yearview .app-calendar-year h1.app-in-header').removeClass('app-in-header');
                        topHeader.addClass('app-in-header');
                    }
                    break;
                case 'month':
                    badges = [
                        String.format('<b>{0}</b> {1}', monthName, year),
                        String.format('<b>{0}</b> {1}', abbrMonthName, year),
                        String.format('<b>{0}</b>', monthName),
                        String.format('<b>{0}</b>', abbrMonthName)
                    ];

                    // hide same date header
                    var topHeader = topPlaceholder.find('h1.app-calendar-month-header');

                    if (!topHeader.is('app-in-header')) {
                        scrollable.find('.app-calendar-monthview .app-calendar-month h1.app-calendar-month-header.app-in-header').removeClass('app-in-header');
                        topHeader.addClass('app-in-header');
                    }
                    break;
                case 'week':
                    var lastPlaceholder = that.getLastVisibleBlock(scrollable),
                        lastDate = lastPlaceholder ? getDateOfBlock(lastPlaceholder) : new Date(),
                        lastYear = lastDate.getFullYear(),
                        lastMonth = lastDate.getMonth(),
                        lastDayNum = lastDate.getDate(),
                        sameMonth = month == lastMonth,
                        sameYear = year == lastYear,
                        lastMonthName = dtf.MonthNames[lastMonth],
                        lastAbbrMonthName = dtf.AbbreviatedMonthNames[lastMonth];
                    if (!lastPlaceholder)
                        return;

                    badges.push(
                        String.format('<b>{0} {1}</b>{2} - <b>{3}{4}</b>, {5}', monthName, dayNum, sameYear ? '' : ', ' + year, sameMonth ? '' : lastMonthName + ' ', lastDayNum, lastYear),
                        String.format('<b>{0} {1}</b>{2} - <b>{3}{4}</b>, {5}', abbrMonthName, dayNum, sameYear ? '' : ', ' + year, sameMonth ? '' : lastAbbrMonthName + ' ', lastDayNum, lastYear)
                    );

                    if (!sameYear)
                        badges.push(
                            String.format('<b>{0} {1}</b>, {2} - <b>{3} {4}</b>', monthName, dayNum, year, lastMonthName, lastDayNum),
                            String.format('<b>{0} {1}</b>, {2} - <b>{3} {4}</b>', abbrMonthName, dayNum, year, lastAbbrMonthName, lastDayNum),
                            String.format('<b>{0} {1}</b>, {2}', monthName, dayNum, year),
                            String.format('<b>{0} {1}</b>, {2}', abbrMonthName, dayNum, year)
                        );
                    else
                        badges.push(
                            String.format('<b>{0} {1}</b> - {2}{3}', monthName, dayNum, sameMonth ? '' : lastMonthName + ' ', lastDayNum),
                            String.format('<b>{0} {1}</b> - {2}{3}', abbrMonthName, dayNum, sameMonth ? '' : lastAbbrMonthName + ' ', lastDayNum),
                            String.format('<b>{0} {1}</b>, {2}', monthName, dayNum, year),
                            String.format('<b>{0} {1}</b>, {2}', abbrMonthName, dayNum, year)
                        );
                    break;
                case 'agenda':
                case 'day':
                    var dayName = dtf.DayNames[dayOfWeekDtf[day]],
                        dayNameReplaceRegex = new RegExp(dayName + '(.?) ', 'i'),
                        dayNameNum = String.format('{0:' + dtf.MonthDayPattern + '}', date),
                        dayNameBoldRegex = new RegExp(dayNameNum, 'i'),
                        longDate = String.format('{0:' + dtf.LongDatePattern + '}', date).replace(dayNameBoldRegex, '<b>' + dayNameNum + '</b>'),
                        longDateWithoutDayOfWeek = longDate.replace(dayNameReplaceRegex, '');

                    badges = [
                        longDate,
                        longDateWithoutDayOfWeek,
                        longDateWithoutDayOfWeek.replace(dtf.MonthGenitiveNames[date.getMonth()], dtf.AbbreviatedMonthGenitiveNames[date.getMonth()])];
                    if (date.getFullYear() == new Date().getFullYear())
                        badges.push('<b>' + dayNameNum + '</b>', String.format('<b> {0:' + dtf.MonthDayPattern.replace(/M+/, 'MMM') + '}</b>', date));
                    badges.push(date.toLocaleDateString());
                    break;
            }

            if (badges[0])
                badge.html(badges[0]).attr('title', badges[0].replace(/<\/?b>|&nbsp;/g, ''));

            while (badge.outerWidth() + 5 > space) {
                var nextBadge = badges[index];
                if (!nextBadge)
                    break;

                badge.html(nextBadge);

                index++;
            }

            if (!tabVisible)
                badge.addClass('app-has-droparrow');
            else
                badge.removeClass('app-has-droparrow');
        },
        // scrolls day or week view in one screen increment (slideleft/right)
        scrollView: function (direction) {
            var scrollable = this.scrollable(),
                dataView = this.dataView,
                view = this.getVisibleView(),
                date,
                increment = (direction == 'next' ? 1 : -1);


            if (direction != 'today')
                date = this.getViewHandler().getNextDate(view, increment);
            else
                date = new Date();


            var target = this.getBlockByDate(view, date);
            if (!target.length) {

                // reload view
                this.navigateDate = date;
                touch.presenter('show', { id: this.dataView._id, name: 'calendar', container: scrollable });
            }
            else
                // scroll to item
                this.scroll({ date: date, animate: true, view: view });
        },
        // trigger data loading for visible blocks in the view
        loadData: function (view) {
            var that = this,
                viewStyle = that.dataView.extension().viewStyle();
            if (this.mode == 'agenda')
                that.activeCalendar.colorMap.load(true);
            if (!view.is(':visible') || this.mode == "agenda" || viewStyle != 'calendar')
                return;
            var scrollable = view.closest('.app-wrapper'),
                block = that.getFirstVisibleBlock(scrollable),
                endBlock = that.getLastVisibleBlock(scrollable);
            if (block && endBlock)
                that.loadDataInBlock(view, block, endBlock);
        },
        // loads data in the block and continues for next visible block
        loadDataInBlock: function (view, block, endBlock) {
            var that = this,
                nextBlock = block.next(':not(.current-time-line)'),
                mode = that.mode;
            if (block[0] == endBlock[0] || !nextBlock.length)
                nextBlock = null;

            if (this.loadingData || that.mode == "agenda")
                return;

            function next() {
                if (nextBlock)
                    that.loadDataInBlock(view, nextBlock, endBlock);
                else
                    that.activeCalendar.colorMap.load(true);
            }

            // already loaded
            if (block.hasClass('data-loaded')) {
                next();
            }
                // load the data
            else {
                // skip load if block not visible
                if (!that.blockIsVisible(view, block)) {
                    next();
                    return;
                }

                var date = getDateOfBlock(block),
                    data = this.cache.select(date);

                // select from database
                if (!data) {
                    this.requestData({
                        mode: mode,
                        date: date,
                        success: function (result) {
                            that.cache.insert(date, result.Pivots.pivot0.Data.slice(1));

                            callback = function () {
                                // check if block is still visible
                                if (that.blockIsVisible(view, block)) {

                                    // clear data from block
                                    switch (mode) {
                                        case "day":
                                            block.find('td > ul').empty();
                                            break;
                                        case "week":
                                            block.find('td > ul').empty();
                                            break;
                                        case "month":
                                            block.find('td > ul').empty();
                                            break;
                                        case "year":
                                            block.find('td.app-has-data').removeClass('app-has-data');
                                            break;
                                        case "agenda":
                                            return;
                                    }

                                    // render data
                                    block.addClass('data-loaded');
                                    data = that.cache.select(date);
                                    if (!$.isEmptyObject(data)) {
                                        that.views[mode].addData(view, date, data);
                                    }
                                    next();
                                }
                                scrollStopCallback = null;
                            }

                            if (isScrolling && !mode.match(/day|week/))
                                scrollStopCallback = callback;
                            else
                                callback();
                        }
                    });
                }
                else {
                    // render data
                    if (!$.isEmptyObject(data)) {
                        this.getViewHandler().addData(view, date, data);
                    }
                    this.loadingData = false;
                    block.addClass('data-loaded');

                    next();
                }
            }
        },
        /* executes a pivot request with the specified options
         * 
         * REQUIRED
         * options.success(result) = function called on success
         *
         * OPTION
         * options.pivots = the pivot definitions
         * options.date = the start date
         * options.end = the end date
         * 
         * OPTIONAL
         * options.mode = the mode to create
         * options.date = the start date
         */
        requestData: function (options) {
            var that = this,
                config = that.activeCalendar,
                executeOptions = {
                    controller: that.dataView._controller,
                    command: options.mode == 'agenda' ? 'Select' : 'Pivot',
                    view: that.dataView._viewId,
                    sort: config.date.Name,
                    tags: that.dataView.get_tags(),
                    success: function (result) {
                        that.loadingData = false;
                        options.success(result);
                    },
                    error: function (error) {
                        that.loadingData = false;
                        $app.alert(String.format('{0}', error.get_message()));
                    }
                };

            if (options.mode) {
                var date = options.date,
                    endDate = new Date(date),
                    config = that.activeCalendar,
                    calendarPivots = {},
                    datePivots = calendarPivots[config.date.Name] = [
                        'calendar-date',
                        'pivot-val2-count',
                        'pivot-row1-year',
                        'pivot-row2-month-raw',
                        'pivot-row3-day'],
                    textPivots = calendarPivots[config.text.Name],
                    colorPivots = config.color ? calendarPivots[config.color.Name] : null,
                    endPivots = config.end ? calendarPivots[config.end.Name] = ['calendar-end'] : null;
                if (!textPivots)
                    textPivots = calendarPivots[config.text.Name] = ['calendar-text'];
                if (config.color && !colorPivots)
                    colorPivots = calendarPivots[config.color.Name] = ['calendar-color'];

                // form filter and pivot
                switch (options.mode) {
                    case 'daylist':
                        endDate.setDate(endDate.getDate() + 1);
                        datePivots.push('pivot-val1-calendar-first100');
                        break;
                    case 'day':
                        endDate.setDate(endDate.getDate() + 1);
                        datePivots.push('pivot-row4-halfhour');
                        datePivots.push('pivot-val1-calendar');
                        break;
                    case 'week':
                        endDate.setDate(endDate.getDate() + 7);
                        datePivots.push('pivot-row3-day', 'pivot-row4-halfhour');
                        datePivots.push('pivot-val1-calendar');
                        break;
                    case 'month':
                        endDate.setMonth(endDate.getMonth() + 1);
                        datePivots.push('pivot-row3-day');
                        datePivots.push('pivot-val1-calendar-first5');
                        break;
                    case 'year':
                        endDate.setYear(endDate.getFullYear() + 1);
                        datePivots.push('pivot-row3-day');
                        break;
                    case 'agenda':
                        break;
                }
                endDate.setSeconds(-1);
                executeOptions.pivotDefinitions = calendarPivots;
                executeOptions._filter = getDateFilter(that.dataView, config.date, null, date, endDate);
            }
            else if (options.pivots && options.date && options.end) {
                executeOptions.pivotDefinitions = options.pivots;
                executeOptions._filter = getDateFilter(that.dataView, config.date, null, options.date, options.end);
            }

            that.loadingData = true;
            $app.execute(executeOptions);
        },
        blockIsVisible: function (view, block) {
            if (!view.is(':visible'))
                return false;
            var scrollable = view.closest('.app-wrapper');
            if (this.mode.match(/month|year/)) {
                var scrollTop = scrollable.offset().top,
                    scrollBottom = scrollTop + scrollable.height(),
                    blockTop = block.offset().top,
                    blockBottom = blockTop + block.height(),

                    topVisible = blockTop <= scrollBottom && blockTop >= scrollTop,
                    bottomVisible = blockBottom >= scrollTop && blockBottom <= scrollBottom,
                    topAboveBottomBelow = blockTop <= scrollTop && blockBottom >= scrollBottom;

                return topVisible || bottomVisible || topAboveBottomBelow;
            }
            else if (this.mode.match(/day|week/)) {
                var pageLeft = 0,
                    pageRight = scrollable.width(),
                    left = block.position().left,
                    right = left + block.width();
                //return (left >= pageLeft && left <= pageRight) || (right >= pageLeft && right <= pageRight);
                return (right >= pageLeft && left <= pageRight);
            }
            else
                return true;
        },
        hasKeyFields: function () {
            return this.dataView._keyFields.length > 0;
        },
        getCurrentKey: function () {
            if (!this.hasKeyFields())
                return null;
            var keyField = this.dataView._keyFields[0],
                row = this.dataView.extension().commandRow();
            return row ? row[keyField.Index] : null;
        },
        // render title text
        getEventTitle: function (date, end, text, color) {
            var title = getClockTime(date, true);

            if (end) //&& isSameDay(date, end))
                title += '-' + getClockTime(end, true);
            title += '\n' + (text ? text : resources.Data.NullValueInForms);
            if (this.activeCalendar.color && color != '')
                title += '\n' + (color ? color : resources.Data.NullValueInForms);
            return title;
        },
        getActionsByName: function (command) {
            var context = [],
                foundActions = [];
            // get the New command
            touch.navContext(context);
            context.forEach(function (action, index) {
                if (action.command == command) {
                    foundActions.push(action);
                }
            });
            return foundActions;
        },
        drawDayData: function (list, date, data, key) {
            var that = this;
            data.rows.forEach(function (event) {
                var li = that.drawEvent(event, key);
                li.appendTo(list);
            });
            this.resizeDayData(list.find('li'));
        },
        drawEvent: function (context, key) {
            var that = this,
                id = context[0],
                date = context[1],
                end = context[2],
                color = context[3],
                text = context[4],
                timeText = getClockTime(date, false, true),
                longTimeText = getClockTime(date);

            if (end) {
                timeText += '-' + getClockTime(end, false, true);
                longTimeText += ' - ' + getClockTime(end);
            }

            var drawText = String.format('<span class="app-event-time">{0}</span> {1} <div class="app-event-time-long">{2}</div>',
                    timeText, text ? text : resources.Data.NullValueInForms, longTimeText),
                li = $('<li class="app-event"></li>').data('data-context', context),
                title = that.getEventTitle(date, end, text, color),
                colorClass = that.activeCalendar.colorMap.className(color);

            // enable drag
            if (touch.desktop()) {
                li.addClass('app-draggable').attr('draggable', 'true');
                if (that.activeCalendar.end)
                    drawText += '<div class="app-event-handle ui-icon-dots app-draggable" draggable="true"></div>';
            }

            // show selection
            if (key && key == id)
                li.addClass('app-calendar-selected');

            if (end)
                li.addClass('app-event-has-end-time');

            li.addClass(colorClass);
            li.html(drawText);
            li.attr('title', title);

            return li;
        },
        resizeDayData: function (eventElements) {

            // initialize eventList
            var eventList = [],
                sameTimeEventList = [],
                stack = [],
                scale = dayAndWeekHeight / 25,
                dayWidth = eventElements.first().closest('.app-calendar-day').width() - (this.mode == "day" ? 150 : 10),
                maxDepth = this.mode == 'day' ? 10 : 4;

            eventElements.each(function () {
                var eventElement = $(this);
                if (eventElement.is('.app-event-more')) {
                    eventElement.remove();
                    return;
                }
                var data = eventElement.data('data-context'),
                    startDate = data[1],
                    endDate = data[2];
                if (!endDate || endDate.getTime() < startDate.getTime()) {
                    endDate = new Date(startDate);
                    endDate.setMinutes(endDate.getMinutes() + eventMinLength);
                }
                else if (endDate.getDate() != startDate.getDate())
                    endDate = new Date(startDate.getFullYear(), startDate.getMonth(), startDate.getDate(), 23, 59, 59);
                eventList.push({
                    element: eventElement,
                    data: data,
                    start: startDate.getTime(),
                    end: endDate.getTime(),
                    depth: 1,
                    width: 0
                });
            });

            // sort by start date
            eventList.sort(function (a, b) {
                if (a.start != b.start)
                    return a.start > b.start ? 1 : -1;
                else if (a.end != b.end)
                    return a.end < b.end ? 1 : -1;
                else
                    return 0;
            });

            // iterate through events
            var lastEvent,
                lastEvents = [],
                lastMore,
                depth = 0;
            eventList.forEach(function (event) {

                lastEvent = stack.pop();
                // determine position
                while (lastEvent) {

                    // last event over
                    if (lastEvent.end <= event.start) {
                        lastEvent = stack.pop();
                        if (!lastEvent) {
                            lastEvents.forEach(function (e) {
                                e.width = depth;
                            });
                            depth = 0;
                            lastEvents = [];
                        }
                    }
                        // overlap
                    else {
                        stack.push(lastEvent);
                        break;
                    }
                }

                function addToStack() {
                    event.depth = stack.length + 1;
                    if (event.depth > depth)
                        depth = event.depth;
                    stack.push(event);
                    lastEvents.push(event);
                }


                if (stack.length >= maxDepth) {
                    if (!lastMore) {
                        lastMore = event;
                        lastMore.collapsedEvents = [event.data];
                        addToStack();
                    }
                    else {
                        event.collapsed = true;
                        lastMore.collapsedEvents.push(event.data);
                    }
                }
                else {
                    lastMore = null;
                    addToStack();
                }
            });

            lastEvents.forEach(function (e) {
                e.width = depth;
            });


            eventList.forEach(function (event) {

                // hide event
                if (event.collapsed) {
                    event.element.hide();
                }

                    // regular display
                else {
                    var elem = event.element,
                        start = event.data[1],
                        end = event.data[2],
                        top = scale * (start.getHours() + (start.getMinutes() / 60)) + 22,
                        height = getEventHeight(event.start, event.end),
                        width = dayWidth / event.width,
                        marginLeft = dayWidth * (event.depth - 1) / event.width;
                    if (event.depth != event.width)
                        width *= 1.3;

                    if (event.collapsedEvents && event.collapsedEvents.length > 1) {
                        elem.hide();

                        var text = '+' + event.collapsedEvents.length + ' ' + resources.Mobile.More;
                        elem = $('<li class="app-event app-event-more ui-icon-dots"></li>').appendTo(elem.closest('ul'))
                            .html(text).attr('title', text)
                            .data('data-more-context', event.collapsedEvents);
                    }

                    var cssOptions = {
                        'top': top,
                        'z-index': event.depth + 2, // add 2 to ensure that timeline is below the event
                        'marginLeft': marginLeft + 'px',
                        'width': width - 3 + 'px'
                    };
                    // set height if end time
                    if (end) {
                        cssOptions['height'] = height;
                    }

                    // set default css
                    elem.css(cssOptions);

                }
            });
        }
    }

    // gets the appropriate event height 
    function getEventHeight(start, end) {
        return (end - start) / 3600000 * (dayAndWeekHeight / 25);
    }

    var Day = function (calendar) {
        this.calendar = calendar;
    }

    Day.prototype = {
        // render a new Day presentation
        draw: function (container, startDate) {
            container.find('.app-calendar-dayview').remove();
            var view = $('<div class="app-calendar-dayview"></div>').appendTo(container),
                isEcho = view.closest('.app-echo').length > 0,
                presenter = view.closest('.app-presenter'),
                scrollable = view.closest('.app-wrapper'),
                header = presenter.data('cal-header'),
                footer = isEcho ? null : presenter.data('cal-footer'),
                distance = isEcho ? 1 : modeDrawDistance.day * 7,
                backDistance = (modeDrawDistance.day - 1) / 2 * 7,
                testDate = new Date(startDate.getFullYear(), startDate.getMonth(), startDate.getDate()),
                grid = '<div class="app-calendar-day-grid"><div class="current-time-line"><div class="dot"></div></div>';

            // set to beginning of week
            testDate.setDate(testDate.getDate() - dtfDayOfWeek[testDate.getDay()]);


            // add day headers
            header.find('.app-day-header').remove();
            var dayHeaders = $('<div class="app-day-header"></div>').appendTo(header),
                dayHeaderList = $('<ul> ' + this.calendar.drawDayHeaders(testDate, distance) + ' </ul>').appendTo(dayHeaders);
            appendClearFix(dayHeaders);

            // draw columns
            grid += this.calendar.drawDayColumns(testDate, distance, true);

            grid += '</div>';
            view.html(grid).find('.app-calendar-day').hide();

            // position elements
            this.resize(view, dayHeaders, footer);
            this.scroll({ view: view, date: startDate, enhancePrecision: true });
            return view;
        },
        showHeaderAndFooter: function (header, footer) {
            header.find('.app-day-header').show();
            header.find('.app-week-header').hide();
            header.find('.app-month-header').hide();

            $app.touch.bar('show', footer);

            this.calendar.lastDayScrollTop = this.calendar.scrollable().scrollTop();
        },
        // Resize the Day presentation
        // view = app-calendar-dayview
        // header = app-day-header
        // footer = app-scroll-inner
        resize: function (view, header, footer) {
            if (!header.is('.app-day-header'))
                header = header.find('.app-day-header');
            var isEcho = view.closest('.app-echo').length > 0,
                grid = view.find('.app-calendar-day-grid'),
                gridItems = view.find('.app-calendar-day'),
                headerItems = header.find('li'),
                scrollable = this.calendar.scrollable(),
                fullWidth = scrollable.outerWidth(),
                itemWidth = Math.floor(fullWidth / 7),
                gridWidth = gridItems.length * fullWidth,
                firstVisibleItem = getFirstVisiblePlaceholder(gridItems),
                firstVisibleHeader = isEcho ? null : getFirstVisiblePlaceholder(headerItems),
                oldLeft = firstVisibleItem.position().left,
                oldHeaderLeft = isEcho ? 0 : firstVisibleHeader.position().left,
                oldMargin = parseInt(view.css('marginLeft'), 10) * -1,
                oldHeaderMargin = isEcho ? 0 : parseInt(header.css('marginLeft'), 10) * -1;

            // set sizes
            grid.width(gridWidth);
            header.width(headerItems.width() * headerItems.length);
            headerItems.closest('ul').css('visibility', '');
            headerItems.width(itemWidth);
            gridItems.width(fullWidth).fadeIn();

            // set height
            view.height(dayAndWeekHeight);

            // restore scroll
            if (!isEcho) {
                var newLeft = firstVisibleItem.position().left,
                    newHeaderLeft = firstVisibleHeader.position().left,
                    diff = oldLeft - newLeft,
                    diffHeader = Math.floor(oldHeaderLeft - newHeaderLeft);

                if (diffHeader != 0)
                    header.css('marginLeft', (oldHeaderMargin * -1) + diffHeader);


                //if (diff != 0)
                this._scroll(view, header, oldMargin - diff, footer);

                if (footer != null)
                    this.calendar.resizeScroller(view, footer, gridWidth);
            }
            // ensure timeline is correct
            drawTime();
            this.resizeData(view);
        },
        scroll: function (options) {
            var that = this,
                calendar = that.calendar,
                row = calendar.dataView.extension().commandRow(),
                scrollable = calendar.scrollable(),
                view = options.view,
                animate = options.animate,
                presenter = view.closest('.app-presenter'),
                header = presenter.data('cal-header').find('.app-day-header'),
                footer = presenter.data('cal-footer'),
                date = options.date,
                scrollTo = calendar.getBlockByDate(view, date);

            if (scrollTo.length) {
                var marginLeft = parseInt(view.css('marginLeft'), 10),
                    distance = scrollTo.position().left;
                that._scroll(view, header, distance - marginLeft, footer, animate);
            }

            // set scroll top
            if (options.enhancePrecision) {
                var top;
                if (row) {
                    var rowDate = row[calendar.activeCalendar.date.Index];
                    top = drawTime(rowDate, 'find');
                }
                else if (!(date.getHours() == 0 && date.getMinutes() == 0 && date.getSeconds() == 0 && date.getMilliseconds() == 0))
                    top = drawTime(date, 'find');
                else
                    top = calendar.lastDayScrollTop || drawTime();
                touch.scroll(scrollable, top);
            }
        },
        // scroll the presentation to the specified positive distance
        // Enable animate to bounce to distance
        _scroll: function (view, header, distance, footer, animate) {

            if (!touch.animate())
                animate = false;

            var oldMarginLeft = parseInt(view.css('marginLeft'), 10),
                distanceNeg = distance * -1,
                timeout,
                that = this,
                grid = view.find('.app-calendar-day-grid');

            view.removeClass('app-has-current-day');

            dayScrollEventCount++;
            // bounce to distance
            if (animate == true) {
                view.animate({ marginLeft: distanceNeg }, animationSpeed,
                    function () {
                        that._scroll(view, header, distance, footer);
                    });
                return;
            }
            // regular scroll
            view.css('marginLeft', distanceNeg);


            var scrollToHeader = this.updateDayHeader(view, header);
            // delayed bounce
            clearTimeout(shiftViewTimeout);
            shiftViewTimeout = setTimeout(function () {
                var columns = view.find('.app-calendar-day'),
                    firstVisibleCol = getFirstVisiblePlaceholder(columns),
                    colWidth = columns.width(),
                    diff = distance % colWidth,
                    date,
                    drawDistance = modeDrawDistance.day * 7,
                    maxRender = modeMaxRender.day * 7;
                // scroll to next day if single event
                if (dayScrollEventCount == 1 && diff != 0) {
                    // going left
                    if (distanceNeg > oldMarginLeft) {
                        diff = diff * -1;
                        firstVisibleCol = firstVisibleCol.prev();
                        if (firstVisibleCol.is('.current-time-line'))
                            firstVisibleCol = firstVisibleCol.prev();
                    }
                        // going right
                    else {
                        diff = colWidth - diff;
                        firstVisibleCol = firstVisibleCol.next();
                        if (firstVisibleCol.is('.current-time-line'))
                            firstVisibleCol = firstVisibleCol.next();
                    }
                    scrollToHeader = that.updateDayHeader(view, header, firstVisibleCol);
                }
                    // normalize difference
                else {
                    if (diff > colWidth / 2)
                        diff = colWidth - diff;
                    else
                        diff = diff * -1;
                }

                var rounded = distanceNeg - diff,
                    roundedNeg = rounded * -1;

                // draw day at left
                if (distance < colWidth) {
                    // draw at left
                    var firstVisibleColumn = columns.first(),
                        oldLeft = firstVisibleColumn.position().left,
                        removedHeadersWidth;
                    date = getDateOfBlock(firstVisibleColumn);
                    date.setDate(date.getDate() - drawDistance);

                    $(that.calendar.drawDayColumns(date, drawDistance, true)).prependTo(grid);
                    var newDayHeaders = $(that.calendar.drawDayHeaders(date, drawDistance)).prependTo(header.find('ul'));

                    // remove extra columns
                    columns = view.find('.app-calendar-day');
                    var headerLi = header.find('li');
                    if (columns.length > maxRender) {
                        columns.slice(maxRender, columns.length).remove();
                        header.find('li').slice(maxRender, columns.length).remove();
                    }

                    // shift and reset
                    view.css('marginLeft', (firstVisibleColumn.position().left - oldLeft) * -1);
                    header.css('marginLeft', scrollToHeader.position().left * -1);
                    if (footer)
                        that.resize(view, header, footer);
                }

                    // draw days at right
                else if (distance > columns.width() * (columns.length - 2)) {
                    // draw at right
                    var firstVisibleColumn = columns.last(),
                        oldLeft = firstVisibleColumn.position().left;
                    date = getDateOfBlock(firstVisibleColumn);
                    date.setDate(date.getDate() + 1);

                    $(that.calendar.drawDayColumns(date, drawDistance, true)).appendTo(grid);
                    $(that.calendar.drawDayHeaders(date, drawDistance)).appendTo(header.find('ul'));

                    // remove extra columns
                    var headerLi = header.find('li'),
                        totalDayCount = columns.length + drawDistance,
                        removedColumnsWidth = 0,
                        removedHeadersWidth = 0;
                    if (totalDayCount > maxRender) {
                        var removedColumns = columns.slice(0, totalDayCount - maxRender),
                            removedHeaders = header.find('li').slice(0, totalDayCount - maxRender);
                        removedColumnsWidth = removedColumns.width() * removedColumns.length;
                        removedHeadersWidth = removedHeaders.width() * removedHeaders.length;
                        removedColumns.remove();
                        removedHeaders.remove();
                    }

                    view.css('marginLeft', parseInt(view.css('marginLeft'), 10) + removedColumnsWidth - diff);
                    header.css('marginLeft', parseInt(header.css('marginLeft'), 10) + removedHeadersWidth);
                    if (footer)
                        that.resize(view, header, footer);
                }
                else {

                    function setScroller() {
                        if (footer && footer.length && footer.scrollLeft() != roundedNeg) {
                            that.calendar.resizeScroller(view, footer);
                            //footer.find('.app-scroll-outer').scrollLeft(roundedNeg).data('resizing', true);
                        }
                    }

                    if (diff != 0)
                        view.animate(
                            { marginLeft: rounded },
                            { duration: animationSpeed, done: setScroller });
                    else
                        setScroller();

                }
                if (firstVisibleCol.is('.current-day-column'))
                    view.addClass('app-has-current-day');
                fetchCalendarData();
                dayScrollEventCount = 0;
            }, 250);
        },
        updateDayHeader: function (view, header, focusColumn) {
            var columns = view.find('.app-calendar-day'),
                firstVisibleCol = (focusColumn && focusColumn.length) ? focusColumn : getFirstVisiblePlaceholder(columns),
                cDate = getDateOfBlock(firstVisibleCol),
                firstVisibleHeader = getFirstVisiblePlaceholder(header.find('ul li')),
                hDate = getDateOfBlock(firstVisibleHeader),
                scrollToHeader = firstVisibleHeader;

            // highlight visible day
            header.find('li .visible-day').removeClass('visible-day');
            var visibleDayHeader = header.find(String.format('li[data-cal-year="{0}"][data-cal-month="{1}"][data-cal-day="{2}"] > a > div', cDate.getFullYear(), cDate.getMonth(), cDate.getDate()));
            visibleDayHeader.addClass('visible-day');


            // set to beginning of week
            cDate.setDate(cDate.getDate() - dtfDayOfWeek[cDate.getDay()]);
            hDate.setDate(hDate.getDate() - dtfDayOfWeek[hDate.getDay()]);

            if (hDate.getTime() != cDate.getTime()) {
                // scroll header
                scrollToHeader = header.find(String.format('li[data-cal-year="{0}"][data-cal-month="{1}"][data-cal-day="{2}"]', cDate.getFullYear(), cDate.getMonth(), cDate.getDate()));
                if (scrollToHeader.length) {
                    var oldHeaderMarginLeft = parseInt(header.css('marginLeft'), 10),
                        marginLeft = oldHeaderMarginLeft - scrollToHeader.position().left;
                    header.css('marginLeft', marginLeft);
                }
            }
            // update header badge
            this.calendar.updateHeader(header.closest('.app-bar-calendar'));
            return scrollToHeader;
        },
        // adds data to the specified date
        addData: function (view, date, data) {
            var dayBlock = this.calendar.getBlockByDate(view, date, 'day'),
                dayList = dayBlock.find('ul.app-calendar-eventlist'),
                keyField = this.calendar.dataView._keyFields[0],
                row = this.calendar.dataView.extension().commandRow(),
                key = row ? row[keyField.Index] : null;

            dayList.empty();

            if (typeof data != 'boolean')
                this.calendar.drawDayData(dayList, date, data, key);
        },
        // properly aligns the data in each day
        resizeData: function (view) {
            var calendar = this.calendar,
                days = view.find('.app-calendar-day');
            days.each(function () {
                var day = $(this),
                    events = day.find('li.app-event:not(.app-event-preview)');
                if (events.length)
                    calendar.resizeDayData(events);
            });
        },
        clear: function (emptyView) {
            var scrollable = this.calendar.scrollable(),
                view = scrollable.find('.app-calendar-dayview');

            if (view.length) {
                var blocks = view.find('div.app-calendar-day.data-loaded');

                blocks.removeClass('data-loaded').removeData('calendar-colors');
                if (emptyView)
                    blocks.find('.app-event').remove();
            }
        },
        getNextDate: function (view, increment) {
            var visible = this.calendar.getMostVisibleBlock(),
                date = getDateOfBlock(visible);
            date.setDate(date.getDate() + increment);
            return date;
        },
        getBlocks: function () {
            var scrollable = this.calendar.scrollable();
            return scrollable.find('.app-calendar-dayview > .app-calendar-day-grid > .app-calendar-day');
        }
    }

    var Week = function (calendar) {
        this.calendar = calendar;
    }

    Week.prototype = {
        draw: function (container, startDate) {
            startDate.setDate(startDate.getDate() - dtfDayOfWeek[startDate.getDay()]);
            container.find('.app-calendar-weekview').remove();
            var view = $('<div class="app-calendar-weekview"></div>').appendTo(container),
                calendar = this.calendar,
                isEcho = view.closest('.app-echo').length > 0,
                distance = isEcho ? 7 : modeDrawDistance.week,
                presenter = view.closest('.app-presenter'),
                scrollable = view.closest('.app-wrapper'),
                header = presenter.data('cal-header'),
                footer = presenter.data('cal-footer'),
                testDate = new Date(startDate.getTime());

            testDate.setDate(testDate.getDate() - distance);

            // add day headers
            header.find('.app-week-header').remove();
            var dayHeaders = $('<div class="app-week-header"></div>').appendTo(header),
                dayHeaderList = $('<ul>' + calendar.drawDayHeaders(testDate, distance * 3) + '</ul>').appendTo(dayHeaders);
            appendClearFix(dayHeaders);

            // add grid
            var gridText = '<div class="app-calendar-week-grid"><div class="current-time-line"><div class="dot"></div></div>';

            // add columnsm
            gridText += calendar.drawTimeColumn(testDate);
            gridText += calendar.drawDayColumns(testDate, distance * 3, false);
            gridText += '</div>';
            view.html(gridText);
            var grid = view.find('.app-calendar-week-grid').hide();

            // position elements
            this.resize(view, dayHeaders, footer);
            this.scroll({ view: view, date: startDate, enhancePrecision: true });
            this.validateCurrentDay(view, grid);
            drawTime();
            return view;
        },
        showHeaderAndFooter: function (header, footer) {
            header.find('.app-day-header').hide();
            header.find('.app-week-header').show();
            header.find('.app-month-header').hide();

            $app.touch.bar('show', footer);

            this.calendar.lastDayScrollTop = this.calendar.scrollable().scrollTop();
        },
        _timelineDot: function (view, show) {
            var scrollable = this.calendar.scrollable(),
                grid = view.find('.app-calendar-week-grid'),
                currentDay,
                timelineDot = grid.find('.current-time-line .dot'),
                newMarginLeft,
                tlw;
            if (show) {
                tlw = timelineDot.show().width();
                currentDay = grid.find('.current-day-column');
                if (currentDay.length) {
                    //timelineDot.css('marginLeft', oldMargin + currentDay.position().left - 70);
                    newMarginLeft = currentDay.offset().left - scrollable.offset().left - tlw / 2 + parseInt(grid.css('margin-left'));
                    if (newMarginLeft + tlw < scrollable.width() - tlw * 3)
                        setTimeout(function () {
                            timelineDot.css('marginLeft', newMarginLeft).show();
                        });
                    else
                        timelineDot.hide();
                }
            }
            else
                timelineDot.hide();
        },
        resize: function (view, header, footer) {
            if (!header.is('.app-week-header'))
                header = header.find('.app-week-header');
            var isEcho = view.closest('.app-echo').length > 0,
                grid = view.find('.app-calendar-week-grid'),
                gridItems = view.find('.app-calendar-week-grid > div:not(.current-time-line):not(.app-calendar-time) > div'),
                headerItems = header.find('li'),
                scrollable = this.calendar.scrollable(),
                fullWidth = scrollable[0].scrollWidth - weekTimeWidth,
                itemWidth = Math.floor(fullWidth / 7),
                gridWidth = itemWidth * (headerItems.length + 1) + weekTimeWidth,
                firstVisibleItem = getFirstVisiblePlaceholder(headerItems),
                oldLeft = isEcho ? 0 : firstVisibleItem.position().left,
                oldMargin = isEcho ? 0 : parseInt(header.css('marginLeft'), 10) * -1;

            // set width of items
            headerItems.width(itemWidth);
            headerItems.closest('ul').css('visibility', '');
            gridItems.width(itemWidth);
            grid.width(gridWidth).fadeIn();

            // set height
            view.height(dayAndWeekHeight);

            if (!isEcho) {
                var newLeft = firstVisibleItem.position().left,
                    diff = oldLeft - newLeft,
                    newPosition = oldMargin - diff;

                // set position of current day dot
                this._timelineDot(view, true);

                // scroll to old position
                //if (diff != 0)
                //    this.scroll(view, header, newPosition);

                if (diff != 0) {
                    view.css('marginLeft', newPosition * -1);
                    header.css('marginLeft', newPosition * -1);
                }
                if (footer != null)
                    this.calendar.resizeScroller(view, footer, gridWidth);

                this.resizeData(view);
            }
            drawTime();
        },
        scroll: function (options) {
            options.date.setDate(options.date.getDate() - dtfDayOfWeek[options.date.getDay()]);
            var that = this,
                calendar = that.calendar,
                view = options.view,
                animate = options.animate,
                date = options.date,
                row = calendar.dataView.extension().commandRow(),
                presenter = view.closest('.app-presenter'),
                scrollable = calendar.scrollable(),
                header = presenter.data('cal-header').find('.app-week-header'),
                footer = presenter.data('cal-footer'),
                scrollTo = calendar.getBlockByDate(view, date);

            if (scrollTo.length) {
                var marginLeft = parseInt(view.css('marginLeft'), 10),
                    distance = scrollTo.position().left - weekTimeWidth;
                that._scroll(view, header, distance - marginLeft, footer, animate);
            }

            // set scroll top
            if (options.enhancePrecision) {
                var top;
                if (row) {
                    var rowDate = row[calendar.activeCalendar.date.Index];
                    top = drawTime(rowDate, 'find');
                }
                else if (!(date.getHours() == 0 && date.getMinutes() == 0 && date.getSeconds() == 0 && date.getMilliseconds() == 0))
                    top = drawTime(date, 'find');
                else
                    top = calendar.lastDayScrollTop || drawTime();
                touch.scroll(scrollable, top);
            }

        },
        _scroll: function (view, header, distance, footer, animate) {
            if (!touch.animate())
                animate = false;
            var that = this,
                calendar = that.calendar,
                scrollable = calendar.scrollable(),
                pageWidth = scrollable.width(),
                grid = view.find('.app-calendar-week-grid'),
                columns = grid.find('.app-calendar-day'),
                calHeader = header.closest('.app-bar-calendar'),
                lastColumn = columns.last(),
                lastColumnWidth = lastColumn.width(),
                maxDistance = lastColumn.position().left - weekTimeWidth + lastColumnWidth,
                scrolled = false,
                firstHeader = header.find('li:first-of-type'),
                firstDate = getDateOfBlock(firstHeader),
                cellWidth = firstHeader.width() + 2,
                maxRender = modeMaxRender.week,
                drawDistance = modeDrawDistance.week,
                addedWidth = lastColumnWidth * drawDistance;

            // update header badge
            that._timelineDot(view, false);
            calendar.updateHeader(calHeader);

            function shiftView() {
                calendar.updateHeader(calHeader);
                if (!scrolled) {
                    // draw day at left
                    if (distance < cellWidth)
                        loadAtLeft();

                        // draw days at right
                    else if (lastColumn.position().left < pageWidth)
                        loadAtRight();

                    else
                        that.validateCurrentDay(view, grid);
                }
                if (footer && footer.length && footer.scrollLeft() != distance)
                    calendar.resizeScroller(view, footer);
                fetchCalendarData(scrollable);
                that._timelineDot(view, true);
            }

            // swaps the replacee with the replacer data, events, and date
            function swapColumns(replacee, replacer, colDate) {
                var dateNum = colDate.getDate();

                replacee
                    .attr('data-cal-year', colDate.getFullYear()).attr('data-cal-month', colDate.getMonth()).attr('data-cal-day', dateNum)
                    .data('calendar-colors', replacer.data('calendar-colors'))
                    .find('ul').empty().append(replacer.find('ul li'));
                replacee[0].className = replacer[0].className;
            }

            // reconfigures a column with the colDate, clears data and events
            function cleanColumn(col, colDate) {
                var dateNum = colDate.getDate();

                col.attr('data-cal-year', colDate.getFullYear()).attr('data-cal-month', colDate.getMonth()).attr('data-cal-day', dateNum);
                col.data('calendar-colors', null);
                col.find('ul').empty().removeClass('data-loaded');
                col[0].className = 'app-calendar-day';
                if (isToday(colDate))
                    col.addClass('current-day-column');
            }

            function loadAtLeft() {
                // draw at left
                scrolled = true;
                var firstVisibleColumn = columns.first(),
                    timeLine = grid.find('.current-time-line'),
                    date = getDateOfBlock(firstVisibleColumn),
                    dataToPosition = false;
                date.setDate(date.getDate() - drawDistance);


                // scroll headers
                var headers = header.find('li'),
                    week1 = columns.slice(0, 7),
                    week2 = columns.slice(7, 14),
                    week3 = columns.slice(14, 21),
                    testDate = new Date(date);

                headers.each(function () {
                    var item = $(this),
                        dateNum = item.find('a div'),
                        testDateNum = testDate.getDate();
                    dateNum.text(testDateNum);
                    item.attr('data-cal-year', testDate.getFullYear()).attr('data-cal-month', testDate.getMonth()).attr('data-cal-day', testDateNum);

                    if (isToday(testDate))
                        dateNum.addClass('app-current-day');
                    else
                        dateNum.removeClass('app-current-day');

                    testDate.setDate(testDateNum + 1);
                });

                // scroll days
                testDate = getDateOfBlock(week2.first());
                week3.each(function (index) {
                    swapColumns($(this), week2.eq(index), testDate);
                    testDate.setDate(testDate.getDate() + 1);
                });


                testDate = getDateOfBlock(week1.first());
                week2.each(function (index) {
                    swapColumns($(this), week1.eq(index), testDate);
                    testDate.setDate(testDate.getDate() + 1);
                });

                testDate = date;
                week1.each(function (index) {
                    cleanColumn($(this), testDate);

                    // try to load data
                    var data = calendar.cache.select(testDate);

                    if (data) {
                        that.addData(view, testDate, data);
                        dataToPosition = true;
                    }

                    testDate.setDate(testDate.getDate() + 1);
                });


                that.validateCurrentDay(view, grid);
                //// shift and reset
                if (dataToPosition)
                    that.resizeData(view);
                distance -= addedWidth;
                if (distance > 0)
                    distance = 0;
                view.css('marginLeft', distance);
                header.css('marginLeft', distance);
                return addedWidth;
            }

            function loadAtRight() {
                // draw at right
                scrolled = true;
                var firstVisibleColumn = columns.first(),
                    timeLine = grid.find('.current-time-line'),
                    date = getDateOfBlock(firstVisibleColumn),
                    dataToPosition = false;
                date.setDate(date.getDate() + drawDistance);


                // scroll headers
                var headers = header.find('li'),
                    week1 = columns.slice(0, 7),
                    week2 = columns.slice(7, 14),
                    week3 = columns.slice(14, 21),
                    testDate = new Date(date);

                headers.each(function () {
                    var item = $(this),
                        dateNum = item.find('a div'),
                        testDateNum = testDate.getDate();
                    dateNum.text(testDateNum);
                    item.attr('data-cal-year', testDate.getFullYear()).attr('data-cal-month', testDate.getMonth()).attr('data-cal-day', testDateNum);

                    if (isToday(testDate))
                        dateNum.addClass('app-current-day');
                    else
                        dateNum.removeClass('app-current-day');

                    testDate.setDate(testDateNum + 1);
                });


                // scroll days
                testDate = getDateOfBlock(week2.first());
                week1.each(function (index) {
                    swapColumns($(this), week2.eq(index), testDate);
                    testDate.setDate(testDate.getDate() + 1);
                });


                testDate = getDateOfBlock(week3.first());
                week2.each(function (index) {
                    swapColumns($(this), week3.eq(index), testDate);
                    testDate.setDate(testDate.getDate() + 1);
                });

                testDate = getDateOfBlock(week3.last());
                testDate.setDate(testDate.getDate() + 1);
                week3.each(function (index) {
                    cleanColumn($(this), testDate);

                    // try to load data
                    var data = calendar.cache.select(testDate);

                    if (data) {
                        that.addData(view, testDate, data);
                        dataToPosition = true;
                    }

                    testDate.setDate(testDate.getDate() + 1);
                });

                that.validateCurrentDay(view, grid);


                distance -= addedWidth;
                if (dataToPosition)
                    that.resizeData(view);
                if (distance > 0)
                    distance *= -1;
                view.css('marginLeft', distance);
                header.css('marginLeft', distance);
                return addedWidth;
            }

            if (animate == true) {

                //// passed the rightmost column
                //if (distance > maxDistance)
                //    distance -= loadAtRight();

                //    // passed the leftmost column
                //else if (distance < 0)
                //    distance += loadAtLeft();

                var diff = distance % lastColumnWidth,
                    rounded = distance * -1 + (diff > lastColumnWidth / 2 ? diff - lastColumnWidth : diff);
                header.animate({ marginLeft: rounded }, animationSpeed);
                view.animate({ marginLeft: rounded }, animationSpeed, function () {
                    setTimeout(function () {
                        shiftView();
                    });
                });
            }
            else {
                var distanceNeg = distance * -1;
                header.css('marginLeft', distanceNeg);
                view.css('marginLeft', distanceNeg);

                // delayed bounce
                clearTimeout(shiftViewTimeout);
                shiftViewTimeout = setTimeout(shiftView, 250);
            }

        },
        // adds data to the specified date
        addData: function (view, date, data) {
            var keyField = this.calendar.dataView._keyFields[0],
                row = this.calendar.dataView.extension().commandRow(),
                key = row ? row[keyField.Index] : null;

            var dayBlock = this.calendar.getBlockByDate(view, date, 'day'),
                dayList = dayBlock.find('ul.app-calendar-eventlist');

            dayList.empty();

            dayList.data('calendar-event-count', data.count || 0);
            this.calendar.drawDayData(dayList, date, data, key);
        },
        resizeData: function (view) {
            var calendar = this.calendar,
                days = view.find('.app-calendar-day');
            days.each(function () {
                var day = $(this),
                    events = day.find('li.app-event:not(.app-event-preview)');
                if (events.length)
                    calendar.resizeDayData(events);
            });
        },
        clear: function (emptyView) {
            var scrollable = this.calendar.scrollable(),
                view = scrollable.find('.app-calendar-weekview');

            if (view.length) {
                var blocks = view.find('div.app-calendar-day.data-loaded');

                blocks.removeClass('data-loaded').removeData('calendar-colors');
                if (emptyView)
                    blocks.find('.app-event').remove();
            }
        },
        validateCurrentDay: function (view, grid) {
            if (!view.is('.app-has-current-day')) {
                if (grid.find('.current-day-column').length)
                    view.addClass('app-has-current-day');
            }
            else if (!grid.find('.current-day-column').length)
                view.removeClass('app-has-current-day');
        },
        getNextDate: function (view, increment) {
            var visible = this.calendar.getMostVisibleBlock(),
                date = getDateOfBlock(visible);
            var day = dtfDayOfWeek[date.getDay()];
            if (day == 0)
                date.setDate(date.getDate() + increment * 7);
            else
                date.setDate(date.getDate() + (increment == -1 ? day * -1 : 7 - day));
            return date;
        },
        getBlocks: function () {
            var scrollable = this.calendar.scrollable();
            return scrollable.find('.app-calendar-weekview > .app-calendar-week-grid > .app-calendar-day');
        }
    }

    var Month = function (calendar) {
        this.calendar = calendar;
    }

    Month.prototype = {
        draw: function (container, startDate) {
            container.find('.app-calendar-monthview').remove();
            var view = $('<div class="app-calendar-monthview"></div>').hide().appendTo(container),
                calendar = this.calendar,
                isEcho = view.closest('.app-echo').length > 0,
                scrollable = view.closest('.app-presenter'),
                header = scrollable.data('cal-header'),
                distance = isEcho ? 0 : modeDrawDistance.month,
                startMonth = startDate.getMonth(),
                testDate = new Date(startDate.getFullYear(), startMonth),
                activeMonth,
                monthName,
                monthBlock;
            testDate.setMonth(testDate.getMonth() - distance);
            activeMonth = testDate.getMonth();

            // add week headers
            header.find('.app-month-header').remove();
            var dayHeaders = $('<div class="app-month-header"></div>'),
                dayHeaderList = $('<ul></ul>').appendTo(dayHeaders);
            for (var i = 0; i < 7; i++) {
                var day = dayOfWeekDtf[i],
                    dayName = dtf.DayNames[day],
                    abbrDayName = dtf.AbbreviatedDayNames[day],
                    li = $('<li><span class="letter-day">' + abbrDayName.substring(0, 1) + '</span>'
                        + '<span class="abbr-day">' + abbrDayName + '</span>'
                        + '<span class="full-day">' + dayName + '</span>'
                        + '</li').attr('title', dayName);

                if (day == 0 || day == 6)
                    li.addClass('app-calendar-weekend');

                li.appendTo(dayHeaderList);
            }
            appendClearFix(dayHeaders);
            dayHeaders.appendTo(header);
            $app.touch.bar('show', header);

            view.fadeIn();

            // add load at top button
            var loadAtTopBlock = $('<div class="app-calendar-load-at-top"></div>').appendTo(view),
                loadAtTopButton = $('<a href="#" class="dv-load-at-top ui-btn"/>').appendTo(loadAtTopBlock).text(resourcesHeaderFilter.Loading);
            if (isEcho)
                loadAtTopBlock.hide();

            // draw months
            for (var i = distance * -1; i <= distance; i++) {
                var monthBlock = this.drawMonth(testDate).appendTo(view);
                testDate.setMonth(activeMonth + 1);
                activeMonth = testDate.getMonth();
            }

            this.resize(view);

            // add load at bottom button
            var loadAtBottomBlock = $('<div class="app-calendar-load-at-bottom"></div>').appendTo(view),
                loadAtBottomButton = $('<a href="#" class="dv-load-at-bottom ui-btn">Load more</a>').appendTo(loadAtBottomBlock).text(resourcesHeaderFilter.Loading);
            if (isEcho)
                loadAtBottomBlock.hide();

            this.scroll({
                date: startDate,
                view: view
            });
            return view;
        },
        showHeaderAndFooter: function (header, footer) {
            header.find('.app-day-header').hide();
            header.find('.app-week-header').hide();
            header.find('.app-month-header').show();

            $app.touch.bar('hide', footer);
        },
        // reset all lists
        resize: function (view, header, footer, resetVisible) {
            var scrollable = view.closest('.app-wrapper'),
                months = view.find('.app-calendar-month'),
                tables = months.find('table'),
                height = scrollable.height() - months.first().find('.app-calendar-month-header').outerHeight();
            if (resetVisible)
                months.removeClass('data-loaded');
            tables.height(height);
            tables.each(function () {
                var table = $(this),
                    rows = table.find('tr');
                rows.height(height / rows.length);
            });
            if (this.calendar.navigateDate && !this.calendar.preventNavigate)
                this.scroll({ view: view, date: this.calendar.navigateDate });
        },
        scroll: function (options) {
            var that = this,
                date = options.date,
                calendar = that.calendar,
                scrollable = calendar.scrollable(),
                presenter = options.view.closest('div.app-presenter'),
                header = presenter.data('cal-header'),
                scrollToPlaceholder = calendar.getBlockByDate(options.view, options.date),
                monthHeader = scrollToPlaceholder.find('.app-calendar-month-header');

            if (!scrollToPlaceholder)
                return;
            scrollToPlaceholder = scrollToPlaceholder.find('td[data-cal-day="' + date.getDate() + '"]');

            var instruction = scrollable.find('.app-presenter-instruction'),
                newScrollTop = Math.abs(scrollToPlaceholder.position().top),
                // 40% of the month header ensures that "sticky header" will not cover the first rows
                newScrollTop = monthHeader.offset().top - scrollable.offset().top + monthHeader.outerHeight(true) - instruction.outerHeight(true) + scrollable.scrollTop();

            function complete() {
                touch.fetchOnDemand();
                fetchCalendarData(scrollable);
            }

            if (options.animate)
                touch.animatedScroll(scrollable, newScrollTop, complete);
            else {
                touch.scroll(scrollable, newScrollTop);
                complete();
            }
        },
        clear: function (emptyView) {
            var scrollable = this.calendar.scrollable(),
                view = scrollable.find('.app-calendar-monthview');

            if (view.length) {
                var blocks = view.find('div.app-calendar-month.data-loaded');

                blocks.removeClass('data-loaded').removeData('calendar-colors');
                if (emptyView)
                    blocks.find('.app-event').remove();
            }
        },
        // creates a single month block
        drawMonth: function (testDate) {
            var activeMonth = testDate.getMonth(),
                monthName = dtf.MonthNames[activeMonth],
                monthBlock = $('<div class="app-calendar-month"></div>')
                    .attr('data-cal-year', testDate.getFullYear()).attr('data-cal-month', activeMonth),
                monthHeader = $('<h1 class="app-calendar-month-header">').appendTo(monthBlock),
                monthTable = $('<table></table>').appendTo(monthBlock);

            if (activeMonth == 0)
                monthHeader.text(String.format('{0} {1}', monthName, testDate.getFullYear()));
            else
                monthHeader.text(monthName);

            var monthDate = new Date(testDate.getFullYear(), testDate.getMonth(), 1),
                dayOfWeek = dtfDayOfWeek[monthDate.getDay()],
                endDate = new Date(testDate.getFullYear(), testDate.getMonth() + 1, 1),
                endDay = dtfDayOfWeek[endDate.getDay()],
                currentRow;

            // set the end date
            if (endDay != 0)
                endDate.setDate(endDate.getDate() + (6 - endDay) + 1);

            // set the start date
            if (dayOfWeek != 0)
                monthDate.setDate(monthDate.getDate() - dayOfWeek);

            // render this month
            while (monthDate < endDate) {
                var dateDay = monthDate.getDay();
                dayOfWeek = dtfDayOfWeek[dateDay];
                if (dayOfWeek == 0)
                    currentRow = $('<tr></tr>').appendTo(monthTable);
                var cell = $('<td></td>').appendTo(currentRow);
                if (dateDay == 0 || dateDay == 6)
                    cell.addClass('app-calendar-weekend');
                if (monthDate.getMonth() == testDate.getMonth()) {
                    cell.html('&nbsp;');
                    cell.attr('data-cal-day', monthDate.getDate());
                    var day = $('<a class="ui-btn"></a>').appendTo(cell),
                        span = $('<span></span>').text(monthDate.getDate()).appendTo(day),
                        dataList = $('<ul></ul>').appendTo(cell),
                        more = $('<li class="app-calendar-month-more"></li>').appendTo(dataList);
                    if (currentDay.setHours(0, 0, 0, 0) == monthDate.setHours(0, 0, 0, 0))
                        span.addClass("app-current-day");
                }

                else
                    cell.html('&nbsp;');
                monthDate.setDate(monthDate.getDate() + 1);
            }
            return monthBlock;
        },
        // adds data to the specified date
        addData: function (view, date, data) {
            var calendar = this.calendar,
                monthBlock = calendar.getBlockByDate(view, date, 'month'),
                dataView = calendar.dataView,
                keyField = dataView._keyFields[0],
                config = calendar.activeCalendar,
                row = calendar.dataView.extension().commandRow(),
                key = row ? row[keyField.Index] : null,
                keyDay = row ? row[config.date.Index] : null,
                monthTdHeight,
                showMore;

            // calculate td height
            var td = monthBlock.find('td').first(),
                button = monthBlock.find('td > a').first(),
                lists = monthBlock.find('ul');

            lists.hide();
            monthTdHeight = td.outerHeight() - button.height();
            lists.show();

            for (var day in data) {
                var dayData = data[day],
                    dayCount = dayData.count,
                    dayDate = null,
                    dayList = monthBlock.find('td[data-cal-day="' + day + '"] ul'),
                    num = 0,
                    selectedRecord,
                    more = $('<li class="app-calendar-month-more"></li>');
                showMore = false;

                dayList.empty().data('calendar-event-count', dayCount);
                while (num < 5) {
                    var row = dayData.rows[num];

                    if (!row)
                        break;

                    var id = row[0],
                        date = row[1],
                        end = row[2],
                        color = row[3],
                        text = row[4],
                        timeText = getClockTime(date, false, true);

                    if (end)
                        timeText += '-' + getClockTime(end, false, true);

                    var drawText = String.format('<span class="app-event-time">{0}</span> {1}', timeText, text ? text : resources.Data.NullValueInForms),
                        li = $('<li class="app-event"></li>').data('data-context', row),
                        title = calendar.getEventTitle(date, end, text, color),
                        colorClass = calendar.activeCalendar.colorMap.className(color);

                    if (touch.desktop())
                        li.addClass('app-draggable').attr('draggable', 'true');

                    // determine whether to show time 

                    if (!dayDate)
                        dayDate = date;

                    // show selection
                    if (key && key == id) {
                        li.addClass('app-calendar-selected');
                        selectedRecord = li;
                    }

                    li.addClass(colorClass);
                    li.html(drawText);
                    li.attr('title', title);
                    li.appendTo(dayList);
                    num++;
                    if (dayList.height() > monthTdHeight && dayCount != 1) {
                        li.remove();
                        showMore = true;
                        num--;
                        break;
                    }
                }

                if (showMore || num < dayData.count) {
                    more.appendTo(dayList);
                    if (showMore) {
                        var prev = more.prev();
                        if (prev.length) {
                            more.prev().remove();
                            num--;
                        }
                    }
                    more.html(String.format(monthMoreFormat, dayCount - num));

                    // show selected record inside more
                    if (key && keyDay)
                        if (keyDay.getDate() == dayDate.getDate() && keyDay.getMonth() == dayDate.getMonth() && keyDay.getFullYear() == dayDate.getFullYear())
                            if (!selectedRecord || (selectedRecord && !selectedRecord.is(':visible')))
                                more.addClass('app-calendar-selected');
                }
            }
        },
        getNextDate: function (view, increment) {
            var calendar = this.calendar,
                visible = calendar.getMostVisibleBlock(),
                date = getDateOfBlock(visible);
            date.setMonth(date.getMonth() + increment);

            // validate next block
            var view = calendar.getVisibleView(),
                block = calendar.getBlockByDate(view, date);

            if (!block.length) {
                if (increment == 1)
                    view.find('.dv-load-at-bottom').trigger('vclick');
                else
                    view.find('.dv-load-at-top').trigger('vclick');
            }
            return date;
        },
        getBlocks: function () {
            var scrollable = this.calendar.scrollable();
            return scrollable.find('.app-calendar-monthview > .app-calendar-month');
        }
    }

    var Year = function (calendar) {
        this.calendar = calendar;
    }

    Year.prototype = {
        draw: function (container, startDate) {
            container.find('.app-calendar-yearview').remove();
            var view = $('<div class="app-calendar-yearview"></div>').hide().appendTo(container),
                isEcho = view.closest('.app-echo').length > 0,
                distance = isEcho ? 0 : modeDrawDistance.year,
                startYear = startDate.getFullYear();
            // add load at top button
            var loadAtTopBlock = $('<div class="app-calendar-load-at-top"></div>').appendTo(view),
                loadAtTopButton = $('<a href="#" class="dv-load-at-top ui-btn"/>').appendTo(loadAtTopBlock).text(resourcesHeaderFilter.Loading);
            if (isEcho)
                loadAtTopBlock.hide();

            for (var year = startYear - distance; year <= startYear + distance; year++)
                var yearBlock = this.drawYear(new Date(year, 0)).appendTo(view);
            view.fadeIn();

            // add load at bottom button
            var loadAtBottomBlock = $('<div class="app-calendar-load-at-bottom"></div>').appendTo(view),
                loadAtBottomButton = $('<a href="#" class="dv-load-at-bottom ui-btn">Load more</a>').appendTo(loadAtBottomBlock).text(resourcesHeaderFilter.Loading);

            if (isEcho)
                loadAtBottomBlock.hide();

            this.scroll({ view: view, date: startDate });
            return view;
        },
        showHeaderAndFooter: function (header, footer) {
            header.find('.app-day-header').hide();
            header.find('.app-week-header').hide();
            header.find('.app-month-header').hide();
            $app.touch.bar('hide', footer);
        },
        // draws a single year block
        drawYear: function (date) {
            var year = date.getFullYear(),
                yearBlock = '<div class="app-calendar-year" data-cal-year="' + year + '"><h1>' + year + '</h1>';
            for (var month = 0; month <= 11; month++) {
                var monthName = dtf.AbbreviatedMonthNames[month].toUpperCase(),
                    monthBlock = '<div class="app-calendar-month" data-cal-month="'
                        + month + '"><a class="ui-btn app-calendar-month-header">'
                        + monthName + '</a><table><thead>';

                for (var day = 0; day < 7; day++) {
                    monthBlock += '<th>' + dtf.ShortestDayNames[dayOfWeekDtf[day]].substr(0, 1) + '</th>';
                }
                monthBlock += '</thead><tbody>';

                monthBlock += createMonthTableBody(year, month);
                yearBlock += monthBlock + '</tbody></table></div>';
            }
            yearBlock += '<div class="app-clear-fix"></div></div>';

            // preload data
            var block = $(yearBlock),
                data = this.calendar.cache.select(date);
            if (data)
                this.addData(null, date, data, block.addClass('data-loaded'));
            return block;
        },
        // adds data to the specified date
        addData: function (view, date, data, block) {
            var calendar = this.calendar,
                yearBlock = block || calendar.getBlockByDate(view, date, 'year');
            yearBlock.find('td.app-has-data').removeClass('app-has-data').attr('title', null);
            for (var month in data) {
                var monthData = data[month],
                    monthBlock = yearBlock.find('div[data-cal-month="' + month + '"]');
                monthBlock.find('td').each(function () {
                    var td = $(this),
                        day = td.text();
                    if (day.trim().length) {
                        var dayData = monthData[day];
                        if (dayData && dayData.count)
                            td.addClass('app-has-data').attr('title', String.format('{0} ({1})', calendar.activeCalendar.date.Label, dayData.count)); // dayData.length
                    }
                });
            }
        },
        scroll: function (options) {
            var that = this,
                date = options.date,
                calendar = that.calendar,
                scrollable = calendar.scrollable(),
                presenter = options.view.closest('div.app-presenter'),
                header = presenter.data('cal-header'),
                scrollToPlaceholder = calendar.getBlockByDate(options.view, options.date);

            if (!scrollToPlaceholder)
                return;
            scrollToPlaceholder = scrollToPlaceholder.find('div.app-calendar-month[data-cal-month="' + date.getMonth() + '"]');

            var instruction = scrollable.find('.app-presenter-instruction'),
                newScrollTop = scrollToPlaceholder.offset().top + scrollable.scrollTop() - scrollable.offset().top - instruction.outerHeight();

            function complete() {
                touch.fetchOnDemand();
                calendar.updateHeader(header);
                fetchCalendarData(scrollable);
            }

            if (options.animate)
                touch.animatedScroll(scrollable, newScrollTop, complete);
            else {
                touch.scroll(scrollable, newScrollTop);
                complete();
            }
        },
        clear: function (emptyView) {
            var scrollable = this.calendar.scrollable(),
                view = scrollable.find('.app-calendar-yearview');

            if (view.length) {
                var blocks = view.find('div.app-calendar-year.data-loaded');

                blocks.removeClass('data-loaded').removeData('calendar-colors');
                if (emptyView)
                    blocks.find('.app-has-data').removeClass('app-has-data').attr('title', null);
            }
        },
        resize: function (view, header, footer) {
            if (this.calendar.navigateDate)
                this.scroll({ view: view, date: this.calendar.navigateDate });
        },
        getNextDate: function (view, increment) {
            var calendar = this.calendar,
                visible = calendar.getMostVisibleBlock(),
                date = getDateOfBlock(visible);
            date.setYear(date.getFullYear() + increment);

            // try to scroll to next block
            var view = calendar.getVisibleView(),
                block = calendar.getBlockByDate(view, date);

            if (!block.length) {
                if (increment == 1)
                    view.find('.dv-load-at-bottom').trigger('vclick');
                else
                    view.find('.dv-load-at-top').trigger('vclick');
            }
            return date;
        },
        getBlocks: function () {
            var scrollable = this.calendar.scrollable();
            return scrollable.find('.app-calendar-yearview > .app-calendar-year');
        }
    }

    var Agenda = function (calendar) {
        this.calendar = calendar;
    }

    Agenda.prototype = {
        draw: function (container, startDate) {
            var view = container.find('.app-calendar-agendaview');

            if (!view.length)
                view = $('<div class="app-calendar-agendaview"></div>').appendTo(container);

            var that = this,
                calendar = this.calendar,
                config = calendar.activeCalendar,
                dataView = calendar.dataView,
                isEcho = view.closest('.app-echo').length > 0,
                date = new Date(startDate),
                list = view.find('.app-calendar-agenda-list'),
                listWasVisible = list.length && view.is('.data-loaded'),
                scrollable = view.closest('.app-wrapper'),
                instruction = scrollable.find('.app-presenter-instruction'),
                loadAtTopBlock = view.find('.app-calendar-load-at-top'),
                loadAtBottomBlock = view.find('.app-calendar-load-at-bottom'),
                stub,
                footer = view.find('.app-echo-footer');

            // hide instruction bar to prevent blink
            if (!isEcho)
                instruction.css('visibility', 'hidden');
            else
                view.height(calendar.echoMaxHeight);

            if (!listWasVisible) {

                // draw list
                if (!list.length)
                    list = $('<ul class="app-calendar-agenda-list"></ul>').hide().appendTo(view);

                // add load at top/bottom button
                if (!isEcho) {
                    if (!loadAtTopBlock.length) {
                        loadAtTopBlock = $('<div class="app-calendar-load-at-top"></div>').hide().prependTo(view);
                        $('<a href="#" class="dv-load-at-top ui-btn"/>').text(resourcesHeaderFilter.Loading).appendTo(loadAtTopBlock);
                    }
                    if (!loadAtBottomBlock.length) {
                        loadAtBottomBlock = $('<div class="app-calendar-load-at-bottom"></div>').hide().appendTo(view);
                        $('<a href="#" class="dv-load-at-bottom ui-btn"></a>').text(resourcesHeaderFilter.Loading).appendTo(loadAtBottomBlock);
                    }
                }
                    // add footer
                else
                    if (!footer.length)
                        footer = $('<div class="app-echo-footer"><div class="app-echo-container-see-all"><a class="ui-btn-icon-left ui-btn ui-icon-carat-r dv-action-see-all"/></div></div>').hide().appendTo(view);
            }

            calendar.cache.clearAgenda();
            that.minPage = 0;
            that.maxPage = 0;
            that.todayLoaded = false;
            that.lastDate = date;

            that.loadData(view, date, 0, function (next, nextCount) {
                that.loadData(view, date, -1, function (prev, lastCount) {

                    list.empty();

                    // join pages
                    var pages = { '0': next[0], '-1': prev['-1'] },

                    // render data
                        visibleCounts = that.drawData(view, date, pages),

                    // get data
                        nextPage = that.calendar.cache.select(1),
                        prevPage = that.calendar.cache.select(-2);

                    // show view
                    list.show();
                    view.fadeIn().css('height', '');

                    if (!isEcho) {
                        instruction.css('visibility', '');
                        if (!nextPage || nextPage.length != 0)
                            loadAtBottomBlock.show();

                        if (!prevPage || prevPage.length != 0)
                            loadAtTopBlock.show();

                        that.scroll({ view: view, date: startDate });
                    }
                    else {
                        var prevIndex = visibleCounts[0],
                            nextIndex = visibleCounts[1],
                            total = nextCount + lastCount,
                            countVisible = prevIndex + nextIndex,
                            startIndex = lastCount - prevIndex + 1,
                            endIndex = startIndex + countVisible - 1;

                        if (countVisible != total) {
                            var seeAll = footer.find('.dv-action-see-all');
                            seeAll.empty();
                            footer.show();
                            $('<span class="app-btn-see-all"/>').appendTo(seeAll).text(resourcesMobile.SeeAll).attr('title', resourcesMobile.SeeAll);
                            $('<span class="app-info"/>').appendTo(seeAll)
                                .attr({ 'data-start-index': startIndex, 'data-end-index': endIndex })
                                .html(String.format(resourcesPager.ShowingItems, startIndex, endIndex, total));
                        }
                    }
                });
            });
            return view;
        },
        showHeaderAndFooter: function (header, footer) {
            header.find('.app-day-header').hide();
            header.find('.app-week-header').hide();
            header.find('.app-month-header').hide();
            $app.touch.bar('hide', footer);
        },
        getNextDate: function (view, increment) {
            var scrollable = this.calendar.scrollable(),
                scrollTop = scrollable.scrollTop(),
                visible = this.calendar.getFirstVisibleBlock(scrollable),
                firstDate = view.find('.app-calendar-agenda-list li:not(.app-calendar-month-header)').first();

            // click next page if necessary
            if (getDateOfBlock(visible).getTime() == getDateOfBlock(firstDate).getTime()) {
                var loadTop = view.find('.dv-load-at-top');
                if (loadTop.is(':visible'))
                    loadTop.trigger('vclick');
            }
            else if (increment == 1 && scrollTop + scrollable.height() > scrollable[0].scrollHeight - 20) {
                var loadBottom = view.find('.dv-load-at-bottom');
                if (loadBottom.is(':visible'))
                    loadBottom.trigger('vclick');
            }

            var next = increment == 1 ? visible.next() : visible.prev();

            if (next.is('.app-calendar-month-header'))
                next = increment == 1 ? next.next() : next.prev();

            if (next.length)
                return getDateOfBlock(next);
            else
                return getDateOfBlock(visible);
        },
        scroll: function (options) {
            var calendar = this.calendar,
                view = options.view || calendar.getVisibleView(),
                date = options.date;

            // redraw view if stale
            if (!view.hasClass('data-loaded')) {
                this.draw(view.closest('.app-calendar'), date);
                return;
            }

            var scrollable = calendar.scrollable(),
                presenter = view.closest('.app-presenter'),
                header = presenter.data('cal-header'),
                scrollTo = calendar.getBlockByDate(view, date),
                firstBlock = this.getBlocks().first(),
                firstDate = getDateOfBlock(firstBlock),
                instruction = scrollable.find('.app-presenter-instruction');

            if (!scrollTo.length) {
                scrollTo = firstBlock;
                // find correct block
                while (scrollTo.length && getDateOfBlock(scrollTo) <= date) {
                    scrollTo = scrollTo.next();
                    if (scrollTo.is('.app-calendar-month-header'))
                        scrollTo = scrollTo.next();
                }
            }
            else
                scrollTo = scrollTo.closest('.app-agenda-day-list');

            if (scrollTo.length) {

                function complete() {
                    touch.fetchOnDemand();
                    fetchCalendarData(scrollable);
                }

                var newScrollTop = 0;
                if (!isSameDay(date, firstDate))
                    newScrollTop = scrollable.scrollTop() + scrollTo.offset().top - scrollable.offset().top - instruction.height();

                if (options.animate)
                    touch.animatedScroll(scrollable, newScrollTop, complete);
                else {
                    touch.scroll(scrollable, newScrollTop);
                    complete();
                }
            }

        },
        resize: function (view, header, footer) {
            if (this.calendar.navigateDate)
                this.scroll({ view: view, date: this.calendar.navigateDate });
        },
        clear: function (view) {
            if (!view)
                view = this.calendar.getViews().filter('.app-calendar-agendaview');
            view.removeClass('data-loaded');
            view.find('.app-calendar-load-at-top, .app-calendar-load-at-bottom').hide();
            this.todayLoaded = false;
            this.calendar.cache.clearAgenda();
        },
        // loads data into view
        // returns added height
        loadData: function (view, date, page, dataCallback) {
            if (!date)
                date = this.lastDate;
            var that = this,
                calendar = that.calendar,
                config = calendar.activeCalendar,
                dataView = calendar.dataView,
                isEcho = view.closest('.app-echo').length > 0,
                list = view.find('.app-calendar-agenda-list'),
                isBackSearch = page < 0,
                filter = !isBackSearch ? getDateFilter(dataView, config.date, config.end, date, null) : getDateFilter(dataView, config.date, config.end, null, date),
                sort = config.date.Name + (isBackSearch ? ' desc' : ' asc'),
                pages = {},
                pageIndex = page >= 0 ? page : Math.abs(page) - 1;

            // save 
            if (page > that.maxPage)
                that.maxPage = page;
            else if (page < that.minPage)
                that.minPage = page;

            var data = calendar.cache.select(page);

            if (!data) {
                calendar.loadingData = true;
                $app.execute({
                    controller: dataView._controller,
                    view: dataView._viewId,
                    command: 'Select',
                    _filter: filter,
                    sort: sort,
                    pageSize: agendaPageSize,
                    pageIndex: pageIndex,
                    requiresRowCount: true,
                    tags: dataView.get_tags(),
                    //requiresRowCount: true,
                    success: function (result) {
                        calendar.loadingData = false;
                        var results = result[dataView._controller];

                        if (calendar.mode != 'agenda')
                            return;

                        var page1 = pageIndex != 0 && results.length > 60 ? results.splice(0, agendaPageSize) : [],
                            page2 = results.splice(0, agendaPageSize),
                            page3 = results;

                        if (!isBackSearch) {
                            if (page != 0)
                                calendar.cache.insert(page - 1, page1);
                            calendar.cache.insert(page, page2);
                            calendar.cache.insert(page + 1, page3);
                        }
                        else {
                            page1.reverse();
                            page2.reverse();
                            page3.reverse();
                            calendar.cache.insert(page - 1, page3);
                            calendar.cache.insert(page, page2);
                            if (page != -1)
                                calendar.cache.insert(page + 1, page1);
                        }
                        pages[page] = page2;

                        if (dataCallback)
                            dataCallback(pages, result.totalRowCount);
                        else
                            that.drawData(view, date, pages, result.totalRowCount);
                    },
                    error: function (error) {
                        calendar.loadingData = false;
                        $app.alert(String.format('{0}', error.get_message()));
                    }
                });
            }
            else {
                pages[page] = data;
                if (dataCallback)
                    dataCallback(pages);
                else
                    that.drawData(view, date, pages);
            }
        },
        drawData: function (view, date, pages) {
            var that = this,
                calendar = that.calendar,
                list = view.find('.app-calendar-agenda-list'),
                scrollable = calendar.scrollable(),
                isEcho = view.closest('.app-echo').length > 0,
                config = calendar.activeCalendar,
                dataView = calendar.dataView,
                startName = config.date.Name,
                textName = config.text.Name,
                colorName = config.color && config.color.Name,
                endName = config.end && config.end.Name,
                keyField = calendar.dataView._keyFields[0],
                commandRow = calendar.dataView.extension().commandRow(),
                key = commandRow ? commandRow[keyField.Index] : null,
                mostVisible = calendar.getMostVisibleBlock(),
                oldTop = mostVisible ? mostVisible.position().top : 0;

            if (config.text.AliasName && config.text.AliasName.length) {
                var alias = dataView.findField(config.text.AliasName);
                if (alias)
                    textName = alias.Name;
            }
            if (config.color && config.color.AliasName && config.color.AliasName.length) {
                var alias = dataView.findField(config.color.AliasName);
                if (alias)
                    colorName = alias.Name;
            }

            function drawRow(row, reverse) {
                var id = keyField && row[keyField.Name],
                    start = row[startName],
                    text = row[textName],
                    end = endName && row[endName],
                    color = colorName && row[colorName],
                    colorClass = config.colorMap.className(color),
                    dayList = that.getDayList(list, start, reverse ? 'prepend' : 'append'),
                    li = $('<li></li>').attr('data-cal-page', page),
                    timeSpan = $('<span class="app-event-time"></span>').appendTo(li),
                    timeSpanText = getClockTime(start),
                    div = $('<div class="app-event"></div>').text(text ? text : resources.Data.NullValueInForms).data('data-context', row).appendTo(li);

                div.attr('title', calendar.getEventTitle(start, end, text, color)).addClass(colorClass);

                // show selection
                if (key && key == id)
                    div.addClass('app-calendar-selected');

                // show time
                if (end)
                    timeSpanText += ' - ' + getClockTime(end);
                timeSpan.text(timeSpanText);
                $('<div class="app-event-time"></div>').text(timeSpanText).appendTo(div);


                if (reverse)
                    li.prependTo(dayList);
                else
                    li.appendTo(dayList);

                return li;
            }

            // echo rendering mode
            if (isEcho) {
                var next = pages[0],
                    prev = pages['-1'],
                    prevKey = prev.length && prev[0][keyField.Name],
                    nextIndex = 0,
                    prevIndex = 0,
                    useNext = true,
                    first = true,
                    maxHeight = calendar.echoMaxHeight - view.find('.app-echo-footer').height(),
                    length = next.length + prev.length,
                    count = 0,
                    firstLi, firstYear, eventToRemove;


                while ((list.outerHeight(true) < maxHeight || count < 3) && count < length) {

                    if (next.length <= nextIndex) {
                        useNext = false;
                    }
                    if (prev.length <= prevIndex) {
                        if (next.length <= nextIndex)
                            break;
                        useNext = true;
                        first = false;
                    }
                    var row = useNext && !first ? next[nextIndex++] : prev[prevIndex++];

                    if (row) {
                        count++;
                        drawRow(row, !useNext);
                    }
                    else {
                        if (useNext)
                            nextIndex--;
                        else
                            prevIndex--;
                        useNext = false;
                    }
                    if (first)
                        first = false;
                }

                // add current time line
                that.validateToday(list, list.children(), date);

                // add year header
                firstLi = list.find('.app-agenda-day-list:first');
                firstYear = firstLi.attr('data-cal-year');
                if (firstLi.length && firstYear != new Date().getFullYear().toString())
                    $('<h1/>').appendTo($('<li class="app-calendar-month-header" data-cal-year="' + firstYear + '" data-cal-month="' + firstLi.attr('data-cal-month') + '"/>').insertBefore(firstLi)).text(firstYear);

                // remove extra events
                var useLast = false,
                    firstLi = list.find('li.app-agenda-day-list').first(),
                    inner = firstLi.find('li').first();
                while (list.outerHeight(true) > maxHeight && count > 3) {

                    var context = inner.find('.app-event').data('data-context'),
                        contextKey = context && context[keyField.Name];
                    if (key && (contextKey == key || contextKey == prevKey)) {
                        useLast = true;
                    }
                    else {

                        inner.remove();
                        count--;

                        // remove empty days
                        if (firstLi.find('li').length == 0) {
                            firstLi.remove();
                            if (useLast)
                                nextIndex--;
                            else
                                prevIndex--;
                        }
                    }

                    if (!useLast) {
                        firstLi = list.find('li.app-agenda-day-list').first();
                        inner = firstLi.find('li').first();
                    }
                    else {
                        firstLi = list.find('li.app-agenda-day-list').last();
                        inner = firstLi.find('li').last();
                    }

                }

                return [prevIndex, nextIndex];
            }

            else {
                for (var page in pages) {
                    var data = pages[page],
                        reverse = page < 0;

                    // hide load-at-top/bottom, no more records
                    if (!data.length) {
                        var prev = view.find('.app-calendar-load-at-top a.ui-btn'),
                            next = view.find('.app-calendar-load-at-bottom a.ui-btn');

                        if (!reverse) {
                            next.text('').removeClass('dv-load-at-bottom');
                            if (!prev.is('.dv-load-at-top'))
                                prev.hide();
                        }
                        else {
                            prev.text('').removeClass('dv-load-at-top');
                            if (!next.is('.dv-load-at-bottom'))
                                next.hide();
                        }
                        continue;
                    }

                    for (var rowNum in data)
                        drawRow(data[rowNum], reverse);
                }


                // ensure headers
                var blocks = calendar.getBlocks(),
                    handledHeaders = [],
                    thisYear = currentDate.getFullYear();
                blocks.each(function () {
                    var day = $(this),
                        year = day.attr('data-cal-year'),
                        month = day.attr('data-cal-month'),
                        key = year + '-' + month;

                    if (handledHeaders[key])
                        return true;

                    monthHeader = view.find(String.format('li.app-calendar-month-header[data-cal-year="{0}"][data-cal-month="{1}"]', year, month));
                    if (!monthHeader.length) {
                        monthHeader = $(String.format('<li class="app-calendar-month-header ui-btn" data-cal-year="{0}" data-cal-month="{1}"><h1>{2}</h1></li>', year, month, dtf.MonthNames[month])).insertBefore(day);
                        if (year != thisYear)
                            monthHeader.find('h1').text(dtf.MonthNames[month] + ' ' + year);
                    }

                    var prev = day.prev();
                    while (prev.length) {
                        if (prev.attr('data-cal-year') != year || prev.attr('data-cal-month') != month) {
                            monthHeader.insertBefore(prev.next());
                            break;
                        }
                        prev = prev.prev();
                    }

                    handledHeaders[key] = true;
                });

                that.validateToday(list, blocks, date);
                view.addClass('data-loaded');

                // set scroll position
                if (mostVisible && reverse)
                    touch.scroll(scrollable, mostVisible.position().top - oldTop);
            }
        },
        validateToday: function (list, blocks, date) {
            // ensure today 
            if (!this.todayLoaded) {
                var first = blocks.first(),
                    firstDate = first.length ? getDateOfBlock(first) : date,
                    last = blocks.last(),
                    lastDate = last.length ? getDateOfBlock(last) : date,
                    inRange = firstDate < currentDay && currentDay < lastDate,
                    prevEvent, eventAfterTimeLine;

                if (inRange || isToday(date)) {
                    this.todayLoaded = true;

                    var today = this.getDayList(list, currentDay, 'search');

                    if (today.find('.app-time-line-container').length)
                        return;

                    var todayRow = today.parents('li[data-cal-year]'),
                        now = new Date(),
                        timeLineLi = $('<li class="app-time-line-container"></li>').appendTo(today),
                        timeLineTime = $('<span class="app-event-time"></span>').text(getClockTime(now)).appendTo(timeLineLi);
                    timeLine = $('<div class="current-time-line"><div class="dot">&nbsp;</div></div>').appendTo(timeLineLi);
                    todayRow.addClass('app-has-current-day');
                    prevEvent = timeLineLi.prev();
                    while (prevEvent.length) {
                        var event = prevEvent.find('.app-event'),
                            context = event.data('data-context');
                        if (context && context[this.calendar.activeCalendar.date.Name] > now)
                            eventAfterTimeLine = prevEvent;
                        else
                            break;
                        prevEvent = prevEvent.prev();
                    }
                    if (eventAfterTimeLine)
                        timeLineLi.insertBefore(eventAfterTimeLine);
                }
            }
        },
        removeData: function (view, page) {

            // remove page
            view.find('.app-calendar-agenda-list li[data-cal-page="' + page + '"]').remove();

            // restore pager
            if (page == this.maxPage) {
                view.find('.app-calendar-load-at-bottom .ui-btn').addClass('dv-load-at-bottom').text(resourcesHeaderFilter.Loading).show();
                this.maxPage--;
            }
            else if (page == this.minPage) {
                view.find('.app-calendar-load-at-top .ui-btn').addClass('dv-load-at-top').text(resourcesHeaderFilter.Loading).show();
                this.minPage++;
            }

            this.removeEmptyRows(view);
        },
        getDayList: function (list, date, insertMode) {
            var dayList = this.calendar.getBlockByDate(list, date);
            if (!dayList.length) {
                var listLi = $('<li class="app-agenda-day-list"></li>')
                        .attr('data-cal-year', date.getFullYear())
                        .attr('data-cal-month', date.getMonth())
                        .attr('data-cal-day', date.getDate()),
                    dayName = dtf.AbbreviatedDayNames[date.getDay()],
                    dayHeader = $(String.format('<h2 class="ui-btn">'
                        + '<span class="app-calendar-daynumbig">{2}</span>'
                        + '<span class="app-calendar-dayname">{0}</span> '
                        + '<span class="app-calendar-monthname">{1}</span> '
                        + '<span class="app-calendar-daynum">{2}</span></h2>', dayName, dtf.AbbreviatedMonthNames[date.getMonth()], date.getDate())).appendTo(listLi).attr('title', String.format('{0:' + dtf.LongDatePattern + '}', date)),
                    dayDiv = $('<div class="app-calendar-day"></div>').appendTo(listLi),
                    yesterday = new Date(),
                    tomorrow = new Date();
                yesterday.setDate(yesterday.getDate() - 1);
                tomorrow.setDate(yesterday.getDate() + 1);

                if (isToday(date))
                    listLi.addClass('app-calendar-agenda-today');
                else if (isSameDay(date, yesterday))
                    listLi.addClass('app-calendar-agenda-yesterday');
                else if (isSameDay(date, tomorrow))
                    listLi.addClass('app-calendar-agenda-tomorrow');


                if (insertMode == 'prepend')
                    listLi.prependTo(list);
                else if (insertMode == 'append')
                    listLi.appendTo(list);
                else {
                    var block = list.find('li[data-cal-year]:first'),
                        lastBlock,
                        blockDate,
                        inserted = false;
                    while (block.length) {
                        blockDate = getDateOfBlock(block);
                        if (date < blockDate) {
                            listLi.insertBefore(block);
                            inserted = true;
                            break;
                        }
                        lastBlock = block;
                        block = block.next();
                    }
                    if (!inserted)
                        listLi.appendTo(list);
                }

                // create day list
                dayList = $('<ul></ul>').appendTo(dayDiv);
                appendClearFix(listLi);
            }
            return dayList;
        },
        removeEmptyRows: function (view) {
            view.find('.app-calendar-agenda-list > li').each(function () {
                var block = $(this),
                    isHeader = block.is('.app-calendar-month-header'),
                    date = getDateOfBlock(block);

                if (isHeader) {
                    var monthBlocks = view.find(String.format('li[data-cal-year="{0}"][data-cal-month="{1}"][data-cal-day]', date.getFullYear(), date.getMonth()));
                    if (monthBlocks.length == 0)
                        block.remove();
                }
                else {
                    var events = block.find('ul .app-event');
                    if (events.length == 0)
                        block.remove();
                }
            });
        },
        getBlocks: function () {
            var scrollable = this.calendar.scrollable();
            return scrollable.find('.app-calendar-agendaview > .app-calendar-agenda-list > li:not(.app-calendar-month-header)');
        }
    };

    // detects if the current view supports calendar
    function supportsCalendar(dataView) {
        if (dataView.calendar)
            return true;

        if (dataView._keyFields.length > 1)
            return false;

        var calendars = [],
            autoCalendars = [],
            doesSupport = false,
            sidebar = touch.sidebar();

        // examples of tags
        // calendar1-start
        // calendar1-end
        // calendar1-text
        // calendar1-name:"My Calendar"
        // calendar1-color

        var calendars = composeCalendars(dataView);

        if ($.isEmptyObject(calendars))
            return false;
        else {
            dataView.calendar = new Calendar(dataView, calendars);
            if (!dataView.calendarPlugin)
                dataView.calendarPlugin = new CalendarPlugin(dataView, calendars);
            return true;
        }
    }

    $app.touch.presenter('register', {
        name: 'calendar',
        icon: function () {
            return 'calendar';
        },
        text: function () {
            return resourcesCalendar.Text;
        },
        supports: supportsCalendar,
        show: function (options) {
            var dataView = $app.find(options.id);
            if (dataView && dataView.calendar)
                dataView.calendar.show(options);

        },
        hide: function (options) {
            var dataView = touch.dataView();
            if (dataView && dataView.calendar)
                dataView.calendar.hide(options);
        },
        dispose: function (options) {
            var dataView = touch.dataView();
            if (dataView && dataView.calendar) {
                dataView.calendar.dispose(options);
                delete dataView.calendar;
            }
        }

    });

    // calendar sidebar plugin
    var CalendarPlugin = function (dataView, calendars) {
        this.dataView = dataView;
        this.calendar = dataView.calendar;
        this.calendars = calendars;
        this.cache = {};
        this.showMonths = 1;
    }

    CalendarPlugin.prototype = {
        getActiveCalendar: function () {
            return this.calendar ? this.calendar.activeCalendar : this.calendars[Object.keys(this.calendars)[0]];;
        },
        attach: function (sidebar) {
            var dataView = this.dataView;
            if (!dataView) {
                this.detach(sidebar);
                return;
            }

            if (!this.calendar)
                this.calendar = this.dataView.calendar;

            this.lastFilter = dataView.combinedFilter().slice();
            if (dataView.get_isTagged('calendar-mini-disabled'))
                return;
            else if (dataView.get_isTagged('calendar-mini-twomonths'))
                this.showMonths = 2;


            var calendar = sidebar.find('.app-calendar-plugin'),
                row = dataView.extension().commandRow(),
                drawDate = this.calendar ? this.calendar.navigateDate || this.calendar.lastDate : null,
                activeCalendar = this.getActiveCalendar(),
                activeField = activeCalendar.date;

            drawDate = row ? new Date(row[activeField.Index]) : null;
            if (!drawDate || isNaN(drawDate.getTime()))
                drawDate = new Date();

            // reload
            if (calendar.length) {
                if (!calendar.is(':visible')) {
                    calendar.addClass('app-show-request');
                }
            }
                // create
            else {
                if (this.attached)
                    return;
                else
                    this.attached = true;

                calendar = $('<div class="app-calendar-plugin app-show-request"></div>').prependTo(sidebar.find('.ui-panel-inner'));
                var header = $('<div class="app-calendar-plugin-header"><div>&nbsp;</div></div>').appendTo(calendar),
                    loadLeftButton = $('<a href="#" class="app-calendar-plugin-loadleft ui-btn ui-btn-corner-all ui-btn-icon-notext ui-icon-carat-l"></a>').attr('title', resources.Pager.Previous).prependTo(header),
                    loadRightButton = $('<a href="#" class="app-calendar-plugin-loadright ui-btn ui-btn-corner-all ui-btn-icon-notext ui-icon-carat-r"></a>').attr('title', resources.Pager.Next).appendTo(header),
                    container = $('<div class="app-month-container"></div>').attr('data-cal-month', drawDate.getMonth()).attr('data-cal-year', drawDate.getFullYear()).appendTo(calendar),
                    fieldSelector = $('<a class="ui-btn ui-btn-icon-none app-has-droparrow app-calendar-plugin-fieldselector"></a>').appendTo(calendar),
                    colorLegend = $('<div class="app-calendar-color-legend"><p class="app-item-desc app-item-desc-before"></p><ol></ol></div>').attr('data-calendar-for', activeCalendar.name).appendTo(calendar).hide(),
                    legendToggle = $('<a class="ui-btn ui-btn-icon-none app-has-droparrow app-legend-toggle"></a>').appendTo(colorLegend),
                    afterLabel = $('<p class="app-item-desc app-item-desc-after"></p>').appendTo(colorLegend);

                $('<span class="app-see-more"></span>').text(resources.Mobile.More).appendTo(legendToggle);
                $('<span class="app-see-less"></span>').text(resourcesCalendar.Less).appendTo(legendToggle);

                // draw month
                for (var i = 0; i < this.showMonths; i++) {
                    var month = $('<div></div>').appendTo(container);
                    if (i == 0)
                        month.addClass('app-first-month');
                    if (i == this.showMonths - 1)
                        month.addClass('app-last-month');
                    drawDate.setMonth(drawDate.getMonth() + 1);
                }

            }
            this.refresh(true);
            return calendar;
        },
        setDate: function (date) {
            var calendar = touch.sidebar().find('.app-calendar-plugin');
            if (calendar.length) {
                calendar.find('.app-month-container').attr('data-cal-year', date.getFullYear()).attr('data-cal-month', date.getMonth());
                this.refresh();
            }
        },
        refresh: function (reloadData) {
            var sidebar = touch.sidebar(),
                calendarPlugin = sidebar.find('.app-calendar-plugin');
            if (!calendarPlugin.length || !this.dataView)
                return;


            var that = this,
                dataView = this.dataView,
                filter = dataView.combinedFilter(),
                container = calendarPlugin.find('.app-month-container'),
                date = getDateOfBlock(container),
                months = calendarPlugin.find('.app-month-container > div'),
                firstMonth = months.first(),
                firstDate = getDateOfBlock(firstMonth),
                dateMonth = date.getMonth(),
                header = calendarPlugin.find('.app-calendar-plugin-header div'),
                headerText = header.text(),
                scrollable = $.mobile.activePage.find('.app-wrapper'),
                calendarView = scrollable.find('.app-calendar'),
                calendarActive = calendarView.length && calendarView.is(':visible'),
                config = that.getActiveCalendar(),
                activeField = config.date;


            // update calendar
            if (date.getFullYear() != firstDate.getFullYear() || date.getMonth() != firstDate.getMonth()) {
                reloadData = true;
                var drawDate = new Date(date);

                // draw first header
                header.html(String.format(miniCalendarHeaderFormat, dtf.MonthNames[drawDate.getMonth()], date.getFullYear()));
                var as = header.find('a'),
                    linkWidth = as.first().outerWidth() + as.eq(2).outerWidth();
                if (linkWidth > header.innerWidth() - 60)
                    header.html(String.format('<a class="ui-btn app-has-droparrow app-month-picker">{0}</a> <a class="ui-btn app-has-droparrow app-year-picker">{1}</a>', dtf.AbbreviatedMonthNames[drawDate.getMonth()], date.getFullYear()));

                months.empty();
                months.each(function (i) {
                    var month = $(this),
                        bodyText = '<table><thead>',
                        headerWidth = header.outerWidth(true) - 2 * calendarPlugin.find('.app-calendar-plugin-header a.app-calendar-plugin-loadleft').width();

                    // render subheader
                    if (i != 0) {
                        var subheader = $('<div></div>').appendTo(month),
                            labels = that.getMonthHeader(drawDate);
                        subheader.text(labels[0]);
                        if (subheader[0].scrollWidth > subheader.innerWidth())
                            subheader.text(labels[1]);
                    }

                    for (var day = 0; day < 7; day++) {
                        var dayDtf = dayOfWeekDtf[day],
                            shortest = dtf.ShortestDayNames[dayDtf],
                            full = dtf.DayNames[dayDtf];
                        bodyText += '<th title="' + full + '">' + shortest + '</th>';
                    }
                    bodyText += '</thead><tbody>' + createMonthTableBody(drawDate.getFullYear(), drawDate.getMonth(), true) + '</tbody></table>';
                    var table = $(bodyText).appendTo(month);

                    if (!month.is('.app-first-month'))
                        table.find('td.app-prev-month').addClass('app-day-hidden');//.text(String.fromCharCode(160)).removeAttr('data-cal-day');
                    if (!month.is('.app-last-month'))
                        table.find('td.app-next-month').addClass('app-day-hidden');//.text(String.fromCharCode(160)).removeAttr('data-cal-day');

                    // hide empty rows
                    table.find('tr').filter(function () {
                        return !$(this).find('td:not(.app-day-hidden), th').length;
                    }).addClass('app-week-hidden');

                    var currentDay = table.find('td.app-current-day');
                    if (currentDay.length) {
                        currentDay.html('<span class="app-current-day">' + currentDay.text() + '</span>');
                    }

                    month.attr('data-cal-month', drawDate.getMonth()).attr('data-cal-year', drawDate.getFullYear());
                    drawDate.setMonth(drawDate.getMonth() + 1);
                });
            }
            var fieldLabel = this.getActiveCalendar().date.Label;
            calendarPlugin.find('.app-calendar-plugin-fieldselector').text(fieldLabel);

            // show active date in calendar view
            clearTimeout(updatePluginTimeout);
            updatePluginTimeout = setTimeout(function () {
                if (calendarActive) {
                    if (sidebar.is(':visible')) {
                        months.find('.app-selected').removeClass('app-selected');
                        var calendar = that.calendar,
                            visible = calendar.getMostVisibleBlock(scrollable);
                        if (!visible)
                            return;
                        var mostVisibleDate = getDateOfBlock(visible),
                            month = that.findMonthByDate(mostVisibleDate);
                        if (!month || !month.length)
                            return;

                        switch (calendar.mode) {
                            case 'year':
                            case 'month':
                                month.find('table tr').filter(function () {
                                    return $(this).find('td.app-next-month, td.app-prev-month, th').length < 7;
                                }).addClass('app-selected');
                                break;
                            case 'week':
                                that.findDayCell(month, mostVisibleDate).parent().addClass('app-selected');
                                break;
                            case 'day':
                                that.findDayCell(month, mostVisibleDate).addClass('app-selected');
                                break;
                        }
                    }
                }
                    // show filter
                else {
                    months.find('.app-selected').removeClass('app-selected');
                    if (filter.length) {
                        // find the filter in calendar and mark as filtered
                        $(filter).each(function () {
                            var fil = this;
                            if (fil.startsWith(activeField.Name)) {
                                var res = /(\w+):(=|\$between\$)(%js%"\\\/Date\(-?\d+?\)\\\/")/.exec(fil);
                                if (!res)
                                    return false;
                                var startDate = dataView.convertStringToFieldValue(activeField, res[3]),
                                    startMonth = that.findMonthByDate(startDate),
                                    endDate = new Date(startDate),
                                    daySelect = res[2] == '=';
                                endDate.setDate(startDate.getDate() + (daySelect ? 1 : 7));
                                endDate.setSeconds(-1);

                                var endMonth = that.findMonthByDate(endDate);
                                if (!startMonth.length && !endMonth.length)
                                    return true;

                                var td = that.findDayCell(container, startDate).add(that.findDayCell(container, endDate));

                                if (td && td.length) {
                                    if (daySelect)
                                        td.addClass('app-selected');
                                    else
                                        td.parent().addClass('app-selected');
                                }
                                return false;
                            }
                        });
                    }
                }
            }, 450);
            that.lastFilter = dataView.combinedFilter().slice();

            // get values in month
            if (reloadData && dataView.get_viewType(dataView._id) == 'Grid') {
                clearTimeout(pluginLoadDataTimeout);
                pluginLoadDataTimeout = setTimeout(function () {
                    container.find('.app-has-data').removeClass('app-has-data').attr('title', '');

                    function loadData(data) {
                        $(data).each(function () {
                            var val = this[1],
                                key = this[0];
                            if (val && val != 0) {
                                if (key.indexOf(', ') < 0)
                                    key = key + ', ' + key;
                                var keyValues = /(\d+), (\d+)/.exec(key),
                                    month = parseInt(keyValues[1], 10) - 1,
                                    day = keyValues[2],
                                    dataDate = new Date(date.getFullYear(), month, day),
                                    cell = that.findDayCell(container, dataDate);
                                cell.addClass('app-has-data').attr('title', String.format('{0} ({1})', activeField.Label, val));
                            }
                        });
                    };

                    // load from cache
                    var key = String.format('{0}-{1}', date.getFullYear(), dateMonth),
                        data = that.cache[key];

                    if (data) {
                        loadData(data);
                    }
                    else {
                        // select data

                        var startDate = new Date(date),
                            startDayOfWeek = dtfDayOfWeek[startDate.getDay()],
                            endDate,
                            calendarPivots = {};

                        if (startDayOfWeek != 0)
                            startDate.setDate(startDate.getDate() - startDayOfWeek);

                        endDate = new Date(startDate);
                        endDate.setDate(endDate.getDate() + 7 + (35 * that.showMonths));

                        endDate.setSeconds(-1);


                        calendarPivots[activeField.Name] = ["pivot-row1-month-raw", "pivot-row2-day"];

                        $app.execute({
                            controller: dataView._controller,
                            command: 'Pivot',
                            view: dataView._viewId,
                            _filter: getDateFilter(dataView, activeField, null, startDate, endDate),
                            sort: '',
                            pivotDefinitions: calendarPivots,
                            tags: dataView.get_tags(),
                            success: function (result) {
                                var p = result.Pivots.pivot0;
                                if (!p)
                                    return;
                                data = that.cache[key] = result.Pivots.pivot0.Data.slice(1);
                                loadData(data);
                            },
                            error: function (error) {
                                $app.alert(String.format('{0}', error.get_message()));
                            }
                        });
                    }
                }, 250);
            }
            //if (calendarActive)
            //    this.calendar.activeCalendar.colorMap.load(calendar);
        },
        clearCache: function () {
            delete this.cache;
            this.cache = {};
            this.refresh(true);
        },
        findMonthByDate: function (date) {
            if (date)
                return touch.sidebar().find(String.format('.app-calendar-plugin .app-month-container > div[data-cal-year="{0}"][data-cal-month="{1}"]', date.getFullYear(), date.getMonth()));
        },
        getMonthHeader: function (date) {
            return [
                dtf.MonthNames[date.getMonth()] + ' ' + date.getFullYear(),
                dtf.AbbreviatedMonthNames[date.getMonth()] + ' ' + date.getFullYear()
            ];
        },
        findDayCell: function (table, date) {
            return table.find(String.format('td[data-cal-month="{0}"][data-cal-day="{1}"]:not(.app-day-hidden)', date.getMonth(), date.getDate()));
        },
        filterWithoutField: function (filter) {
            var name = this.getActiveCalendar().date.Name;
            return filter.filter(function (f) {
                return !f.startsWith(name);
            }).join('');
        },
    };

    function detachPlugin(sidebar) {
        if (!sidebar)
            sidebar = touch.sidebar();
        sidebar.find('.app-calendar-plugin').addClass('app-hide-request');
    }

    $(document)
        .on('vclick', '.app-calendar-plugin', function (event, skipHighlight) {
            var originalTarget = $(event.target),
                target = originalTarget,
                dataView = touch.dataView(),
                that = dataView.calendarPlugin,
                calendar = target.closest('.app-calendar-plugin'),
                container = calendar.find('.app-month-container'),
                colorLegend = calendar.find('.app-calendar-color-legend'),
                table = target.closest('table'),
                activeField = that.getActiveCalendar().date;

            // use first month if no month found

            if (!table.length)
                table = calendar.find('.app-month-container > div:first-of-type > table');
            var month = table.parent(),
                date = getDateOfBlock(month);

            if (target.is('span.app-current-day'))
                originalTarget = target = target.closest('td');

            if (target.is('td')) {
                var row = target.closest('tr'),
                    selectedRow = container.find('tr.app-selected'),
                    selectedDay = container.find('td.app-selected'),
                    rowSelected = row.hasClass('app-selected'),
                    daySelected = target.hasClass('app-selected'),
                    scrollable = $.mobile.activePage.find('.app-wrapper'),
                    calendarView = scrollable.find('.app-calendar'),
                    filterOperation = '',
                    calendarActive = calendarView.length && calendarView.is(':visible'),
                    calendarConfig = dataView.calendar;

                if ((!calendarActive && (!rowSelected && !selectedDay.length)) || (calendarActive && calendarConfig.mode == 'week')) {
                    // scan back for date
                    while (target.is('.app-prev-month')) {
                        target = target.next();
                    }
                    // scan forward for date
                    if (!target.length)
                        target = originalTarget;
                    while (target.is('.app-next-month')) {
                        target = target.prev();
                    }
                    if (!target.length)
                        target = originalTarget;
                }
                var day = target.text().trim();
                if (day.length == 0 || target.is('.app-day-hidden'))
                    return;
                date.setDate(day);

                // set correct month
                if (target.is('.app-prev-month')) {
                    date.setMonth(date.getMonth() - 1);
                    if (!that.findMonthByDate(date).length)
                        container.attr('data-cal-month', date.getMonth()).attr('data-cal-year', date.getFullYear());
                }
                else if (target.is('.app-next-month')) {
                    date.setMonth(date.getMonth() + 1);
                    if (!that.findMonthByDate(date).length) {
                        container.attr('data-cal-month', date.getMonth()).attr('data-cal-year', date.getFullYear());
                    }
                }

                var highlight = target,
                    newMode;

                if (!calendarActive) {
                    if (!selectedDay.length) {
                        if (!selectedRow.length || !rowSelected) {
                            // filter by week when no selection
                            date.setDate(date.getDate() - dtfDayOfWeek[date.getDay()]);
                            var endDate = new Date(date);
                            endDate.setDate(date.getDate() + 7);
                            endDate.setSeconds(-1);
                            filterOperation = '$between$';
                            highlight = row;
                        }
                        else
                            // filter day when week selected
                            filterOperation = '=';
                    }
                    else if (target.is('.app-selected'))
                        // clear filter
                        filterOperation = 'clear';
                    else
                        // filter day
                        filterOperation = '=';
                }
                else {
                    switch (calendarConfig.mode) {
                        case 'year':
                            newMode = 'Month';
                            highlight = table.find('tbody tr').filter(function () {
                                return $(this).find('td.app-next-month, td.app-prev-month, th').length < 7;
                            });
                            break;
                        case 'month':
                            if (rowSelected) {
                                newMode = 'Week';
                                highlight = row;
                                date.setDate(date.getDate() - dtfDayOfWeek[date.getDay()]);
                            }
                            else {
                                newMode = 'Month';
                                highlight = table.find('tbody tr').filter(function () {
                                    return $(this).find('td.app-next-month, td.app-prev-month, th').length < 7;
                                });
                            }
                            break;
                        case 'week':
                            if (rowSelected) {
                                newMode = 'Day';
                            }
                            else {
                                newMode = 'Week';
                                highlight = row;
                                date.setDate(date.getDate() - dtfDayOfWeek[date.getDay()]);
                            }
                            break;
                        case 'day':
                            if (daySelected) {
                                newMode = 'Week';
                                highlight = row;
                                date.setDate(date.getDate() - dtfDayOfWeek[date.getDay()]);
                            }
                            else {
                                newMode = 'Day';
                            }
                            break;
                        case 'agenda':
                            newMode = 'Agenda';
                            calendarConfig.animate = true;
                            calendarConfig.enhancePrecision = true;
                            break;
                    }
                }

                highlight.addClass('ui-btn-active');
                setTimeout(function () {
                    highlight.removeClass('ui-btn-active');
                    if (calendarActive) {
                        // synchronize calendar view
                        dataView.calendar.navigateDate = new Date(date);
                        if (newMode.toLowerCase() == calendarConfig.mode)
                            touch.presenter('show', { id: dataView._id, name: 'calendar', container: scrollable });
                        else {
                            var link = findTab(scrollable.parent().find('.app-bar-header .app-bar-calendar'), resourcesCalendar[newMode]);
                            if (link)
                                link.trigger('vclick');
                        }
                        that.refresh();
                    }
                    else {
                        // apply filter to view
                        dataView.extension()._instructed = false;
                        that.filtering = true;
                        switch (filterOperation) {
                            case '=':
                                dataView.applyFieldFilter(activeField.Index, '=', [date]);
                                break;
                            case '$between$':
                                dataView.applyFieldFilter(activeField.Index, '$between', [date, endDate]);
                                break;
                            case 'clear':
                                dataView.removeFromFilter(activeField);
                                dataView.sync();
                                break;
                        }
                        that.filtering = false;
                        that.refresh();
                    }
                }, timeoutSpeed);

                return false;
            }
            else if (target.is('.ui-btn-icon-notext')) {
                // handle left/right buttons

                // set date
                if (target.is('.app-calendar-plugin-loadleft'))
                    date.setMonth(date.getMonth() - that.showMonths);
                else if (target.is('.app-calendar-plugin-loadright'))
                    date.setMonth(date.getMonth() + that.showMonths);
                container.attr('data-cal-year', date.getFullYear());
                container.attr('data-cal-month', date.getMonth());

                function refresh() {
                    that.refresh(true);
                }

                // refresh
                if (skipHighlight)
                    setTimeout(refresh);
                else
                    touch.callWithFeedback(target, refresh);
                return false;
            }
            else if (target.is('.app-calendar-plugin-fieldselector')) {
                var items = [];

                // add fields
                $(that.calendars).each(function () {
                    var calendarConfig = this,
                        field = calendarConfig.date,
                        activeField = that.getActiveCalendar().date;
                    items.push({
                        text: field.Label,
                        icon: field == activeField ? 'check' : '',
                        callback: function () {
                            dataView.calendar.preventNavigate = true;
                            if (activeField == field)
                                return;
                            dataView.removeFromFilter(activeField);
                            that.calendar.activeCalendar.colorMap.clearFilter();
                            that.calendar.activeCalendar = calendarConfig;
                            var config = dataView.viewProp('calendarConfig');
                            config.activeCalendar = calendarConfig.name;
                            dataView.viewProp('calendarConfig', config);
                            that.calendar.clear(true);
                            dataView.sync();
                        }
                    });
                });

                // today button
                items.push({},
                    {
                        text: resourcesCalendar.Today,
                        icon: 'calendar',
                        callback: function () {
                            that.setDate(new Date());
                        }
                    });

                // sync button
                var dataView = touch.dataView(),
                    scrollable = $.mobile.activePage.find('.app-wrapper'),
                    calendarView = scrollable.find('.app-calendar'),
                    calendarActive = calendarView.length && calendarView.is(':visible'),
                    syncDate,
                    label = resourcesCalendar.Sync;

                if (calendarActive) {
                    var calendar = dataView.calendar,
                        block = calendar.getMostVisibleBlock(scrollable);
                    syncDate = getDateOfBlock(block);
                }
                else {
                    var row = dataView.extension().commandRow();
                    if (row)
                        syncDate = new Date(row[that.getActiveCalendar().date.Index]);
                }
                if (syncDate && !isNaN(syncDate.getTime())) {
                    label = String.format('{0} {1}', dtf.MonthNames[syncDate.getMonth()], syncDate.getFullYear());
                    items.push({
                        text: label,
                        icon: 'recycle',
                        callback: function () {
                            that.setDate(syncDate);
                        }
                    });
                }

                // popup
                touch.callWithFeedback(target, function () {
                    touch.listPopup({
                        anchor: target,
                        iconPos: 'left',
                        items: items
                    });
                });
                return false;
            }
                // handle color filter
            else if (target.is('.app-calendar-color-legend ol li, .app-calendar-color-legend ol li span')) {
                var calendar = dataView.calendar,
                    colorMap = calendar.activeCalendar.colorMap,
                    visibleColors = colorMap.getVisibleColors().map(function (x) { return colorMap.color(x); }),
                    body = $('body'),
                    event = target.is('.app-event') ? target : target.find('.app-event'),
                    colorClass = event.attr('class').match(/app-event-color-(\d+)/),
                    bodyColorClass = body.attr('class').match(/app-event-filter-color-(\d+)/),
                    oldColorVisible = true;

                if (colorClass) {
                    var color = parseInt(colorClass[1], 10),
                        newColorClass = 'app-event-filter-color-' + color,
                        bodySameColor = body.is('.' + newColorClass);

                    if (bodyColorClass) {
                        var oldColor = parseInt(bodyColorClass[1], 10);
                        oldColorVisible = visibleColors.indexOf(oldColor) != -1;

                    }

                    colorMap.clearFilter();

                    if (!bodySameColor && oldColorVisible) {
                        // set filter
                        body.addClass('app-event-filter ' + newColorClass);


                        var scrollable = calendar.scrollable(),
                            firstVisible = calendar.getFirstVisibleBlock(scrollable),
                            lastVisible = calendar.getLastVisibleBlock(scrollable),
                            scrollTop = scrollable.position().top,
                            scrollBottom = scrollTop + scrollable.height(),
                            lastVisibleTop,
                            firstVisibleBottom,
                            done = false,
                            isVisible = false;

                        do {
                            var events = firstVisible.find('.app-event.app-event-color-' + color);
                            events.each(function () {
                                var event = $(this),
                                    eventTop = event.offset().top;

                                if (eventTop < scrollTop) {
                                    if (calendar.mode == 'month' || !lastVisibleTop || lastVisibleTop.offset().top < eventTop)
                                        lastVisibleTop = event;
                                }
                                else if (eventTop + event.height() > scrollBottom) {
                                    firstVisibleBottom = event;
                                    done = true;
                                    return false;
                                }
                                else {
                                    isVisible = true;
                                    done = true;
                                    return false;
                                }
                            });
                            firstVisible = firstVisible.next();
                        } while (!done && firstVisible != lastVisible && firstVisible.length);

                        if (!isVisible && (firstVisibleBottom || lastVisibleTop)) {
                            var stp = firstVisibleBottom || lastVisibleTop,
                                newScrollTop;
                            switch (calendar.mode) {
                                case 'day':
                                case 'week':
                                    var context = stp.data('data-context');
                                    if (context) {
                                        var date = context[1];
                                        newScrollTop = drawTime(date, 'find');
                                    }
                                    break;
                                case 'month':
                                case 'agenda':
                                    newScrollTop = scrollable.scrollTop() + stp.offset().top - scrollable.position().top + (stp.height() - scrollable.height()) / 2;
                                    break;
                            }
                            if (newScrollTop != null)
                                touch.animatedScroll(scrollable, newScrollTop);
                        }
                    }
                }
                return false;
            }

                // handle see more/see less
            else if (target.is('.app-legend-toggle, .app-see-more, .app-see-less')) {
                touch.callWithFeedback(target, function () {
                    colorLegend.toggleClass('app-see-all');
                });
                return false;
            }
                // handle date picker
            else if (target.is('.app-has-droparrow')) {
                var items = [],
                    m = date.getMonth(),
                    y = date.getFullYear();

                function changeMonth(toMonth) {
                    container.attr('data-cal-month', toMonth);
                    that.refresh(true);
                }

                function changeYear(toYear) {
                    container.attr('data-cal-year', toYear);
                    that.refresh(true);
                }

                if (target.is('.app-month-picker'))
                    for (var i = 0; i < 12; i++)
                        items.push({
                            text: dtf.MonthNames[i],
                            icon: m == i ? 'check' : false,
                            visible: m == i ? true : false,
                            callback: changeMonth,
                            context: i
                        });
                else
                    for (var i = y - 10; i <= y + 10; i++)
                        items.push({
                            text: i,
                            icon: y == i ? 'check' : false,
                            visible: y == i ? true : false,
                            callback: changeYear,
                            context: i
                        });

                touch.callWithFeedback(target, function () {
                    touch.listPopup({
                        anchor: target,
                        iconPos: 'right',
                        items: items
                    });
                });

                return false;
            }
        })
        .on('swipeleft', '.app-calendar-plugin-header, .app-calendar-plugin .app-month-container', function (event) {
            var target = $(event.target),
                calendar = target.closest('.app-calendar-plugin'),
                button = calendar.find('.app-calendar-plugin-loadright');
            if (button.length) {
                event.preventDefault();
                button.trigger('vclick', true);
            }
        })
        .on('swiperight', '.app-calendar-plugin-header, .app-calendar-plugin .app-month-container', function (event) {
            var target = $(event.target),
                calendar = target.closest('.app-calendar-plugin'),
                button = calendar.find('.app-calendar-plugin-loadleft');
            if (button.length) {
                event.preventDefault();
                button.trigger('vclick', true);
            }
        });

    var ColorMap = function (dataView, calendar, map) {
        this.dataView = dataView;
        this.calendar = calendar;
        this.map = map;
        if (!this.map)
            this.map = {};
        this.count = 0;
        for (var item in this.map)
            if (this.map.hasOwnProperty(item))
                this.count++;
    }

    ColorMap.prototype = {
        color: function (value) {
            if (value == undefined || value == null)
                return 0;
            var that = this,
                color = this.map[value];
            if (typeof color == 'undefined') {
                color = this.map[value] = 1 + this.count % maxColorCount;
                this.count++;
                if (that.calendar.color) {
                    clearTimeout(saveColorsTimeout);
                    saveColorsTimeout = setTimeout(function () {
                        that.dataView.viewProp('calendarColorMap-' + that.calendar.color.Name, that.map);
                        that.dataView.calendarPlugin.refresh(false, true);
                    }, 1000);
                }
            }
            return color;
        },
        className: function (value) {
            return ('app-event-color-' + this.color(value));
        },
        // display the color legend and calculate colors
        load: function (reload) {
            var that = this;
            clearTimeout(loadColorLegendTimeout);
            loadColorLegendTimeout = setTimeout(function () {
                var sidebar = touch.sidebar(),
                    colorLegend = sidebar.find('.app-calendar-color-legend'),
                    toggleLegend = sidebar.find('a.app-legend-toggle'),
                    list = colorLegend.find('ol'),
                    config = that.calendar,
                    colorField = config ? config.color : null;

                if (!config || !colorField || !sidebar.is(':visible')) {
                    if (colorLegend.length)
                        that.hide();
                    return;
                }

                var label = colorField.Label,
                    count = 0,
                    lastVal;

                if (reload || list.is(':empty') || config.name != colorLegend.attr('data-calendar-for')) {

                    // find all used colors
                    var firstBlock = that.dataView.calendar.getFirstVisibleBlock(),
                        colors = that.getVisibleColors(),
                        currentColors = colorLegend.data('calendar-colors') || [];

                    if (!firstBlock || (!firstBlock.hasClass('data-loaded') && that.dataView.calendar.mode != 'agenda'))
                        return;

                    // stop if the colors are the same as displayed
                    if (colors.length == currentColors.length && colors.join('') == currentColors.join(''))
                        return;
                    colorLegend.data('calendar-colors', colors);

                    list.empty();
                    colors.forEach(function (val, index) {
                        var cssClass = that.className(val),
                            text = val || resources.Data.NullValueInForms;
                        if (cssClass) {
                            var li = $('<li></li>').text(text),
                                span = $('<span class="app-event">&nbsp;</span>').addClass(cssClass).appendTo(li);
                            if (count++ >= maxLegendVisible)
                                li.addClass('app-hidden');
                            li.appendTo(list);
                        }
                        lastVal = val;
                    });

                    colorLegend.attr('data-calendar-for', config.name);

                    if (colorField.AliasName && colorField.AliasName.length) {
                        var alias = that.dataView.findField(colorField.AliasName);
                        if (alias)
                            label = alias.Label;
                    }

                    colorLegend.find('.app-item-desc').text(label);

                    if (count <= maxLegendVisible)
                        toggleLegend.addClass('app-hidden');
                    else
                        toggleLegend.removeClass('app-hidden');

                    if (count == 0 || !config.color)
                        colorLegend.addClass('app-hidden');
                    else
                        colorLegend.removeClass('app-hidden');
                    that.show();
                }
            }, 450);
        },
        show: function () {
            var sidebar = touch.sidebar();
            if (!sidebar.is(':visible') || this.dataView.calendar.mode == 'year')
                return;
            var legend = sidebar.find('.app-calendar-color-legend'),
                activePage = this.dataView.calendar.scrollable(),
                calendar = activePage.find('.app-calendar'),
                legendHidden = !legend.is(':visible');
            if (!legend.is('.app-hidden') && calendar.is(':visible') && legend.find('ol li').length) {
                if (legendHidden)
                    legend.show();
            }
            else
                this.hide();
        },
        hide: function () {
            var sidebar = touch.sidebar(),
                legend = sidebar.find('.app-calendar-color-legend');
            legend.hide();
        },
        getVisibleColors: function () {
            var colors = [],
                calendar = this.dataView.calendar,
                scrollable = calendar.scrollable(),
                firstBlock = calendar.getFirstVisibleBlock(scrollable),
                lastBlock = calendar.getLastVisibleBlock(scrollable),
                isAgenda = calendar.mode == "agenda",
                index = isAgenda ? (calendar.activeCalendar.color.AliasName || calendar.activeCalendar.color.Name) : 3;

            if (calendar.mode != 'year')
                while (firstBlock && firstBlock.length) {
                    var blockColors = firstBlock.data('calendar-colors');

                    if (!blockColors && (firstBlock.hasClass('data-loaded') || isAgenda)) {
                        blockColors = [];
                        var date = getDateOfBlock(firstBlock),
                            data;

                        // do not use data from cache
                        if (isAgenda) {
                            var events = firstBlock.find('.app-event');
                            events.each(function () {
                                var data = $(this).data('data-context'),
                                    color = data[index];
                                if (blockColors.indexOf(color) == -1)
                                    blockColors.push(color);
                            });
                        }
                        else {
                            data = calendar.cache.select(date);
                            for (var day in data) {
                                var rows = data[day].rows || data.rows;
                                for (var row in rows) {
                                    var color = rows[row][index];
                                    if (blockColors.indexOf(color) == -1)
                                        blockColors.push(color);
                                }
                                if (calendar.mode.match(/day|week/))
                                    break;
                            }
                        }

                        firstBlock.data('calendar-colors', blockColors);
                    }

                    if (blockColors)
                        blockColors.forEach(function (val) {
                            if (colors.indexOf(val) == -1)
                                colors.push(val);
                        });

                    if (firstBlock[0] == lastBlock[0])
                        break;
                    firstBlock = firstBlock.next();
                }
            return colors.sort();
        },
        clearFilter: function () {
            var colors = [];
            for (var i = 0; i <= 23; i++)
                colors.push('app-event-filter app-event-filter-color-' + i);
            $('body').removeClass(colors.join(' '));
        }
    };
})();
//(function () { 
//    $app.touch.presenter('register', {
//        name: 'shopping-cart',
//        icon: function () { return 'shop' },
//        text: function () { return 'Shopping Cart' },
//        echo: function () { return false; },
//        supports: function (dataView) {
//            return true;
//        },
//        show: function (options) {
//        },
//        hide: function (options) {
//        },
//        dispose: function (options) {
//        }
//    });
//})();