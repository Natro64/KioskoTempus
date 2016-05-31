using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace IXport.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Empleado
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDEmpleado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombreCompleto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _apellidoPaterno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _apellidoMaterno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rfc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaResidencia;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaNacimiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaRevisionSalario;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _multilingue;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _pasaporte;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _idiomas;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lugarMatrimonio;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lugarNacimiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTransporte;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nacionalidad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTipovivienda;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDEstadonacimiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDMunicipionacimiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cursosAnteriores;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _puestosAnteriores;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _estudiaActualmente;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _horarioEstudiante;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _zonaEconomica;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte[] _foto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte[] _firma;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDPlantilla;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iDJefedirecto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaIngreso;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaBaja;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaPrestaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaSigEvaluacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaInicioContrato;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fechaVencContra;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDPatron;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTabulador;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDPrestaciones;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _salarioTabulador;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _salarioIntegradoAnterior;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _salarioDiarioAnterior;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _salarioDiario;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _factorIntegracion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _salarioVariables;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDPuesto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDTurno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDDepartamento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDCentrocosto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDClasificacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDSupervisor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _passwordPortal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modificadoPor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _creadoEn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _modificadoEn;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDRuta;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iDDelegacion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _salarioPreIntegrado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _salarioTope;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatusDescripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _discapacidad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _tipoDiscapacidad;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _institucion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _tipoInstitucion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _carreraTerminada;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _tipoDocProb;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _anioEmision;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _salarioPercepcionesFijas;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _salarioIntegrado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cuentaContable;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cuentaContable2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _usID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nuevoPassword;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _confirmarContrasena;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _confirmarPassword;
        
        public Empleado()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? IDEmpleado
        {
            get
            {
                return _iDEmpleado;
            }
            set
            {
                _iDEmpleado = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string NombreCompleto
        {
            get
            {
                return _nombreCompleto;
            }
            set
            {
                _nombreCompleto = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string ApellidoPaterno
        {
            get
            {
                return _apellidoPaterno;
            }
            set
            {
                _apellidoPaterno = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string ApellidoMaterno
        {
            get
            {
                return _apellidoMaterno;
            }
            set
            {
                _apellidoMaterno = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Rfc
        {
            get
            {
                return _rfc;
            }
            set
            {
                _rfc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? FechaResidencia
        {
            get
            {
                return _fechaResidencia;
            }
            set
            {
                _fechaResidencia = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? FechaRevisionSalario
        {
            get
            {
                return _fechaRevisionSalario;
            }
            set
            {
                _fechaRevisionSalario = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? Multilingue
        {
            get
            {
                return _multilingue;
            }
            set
            {
                _multilingue = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? Pasaporte
        {
            get
            {
                return _pasaporte;
            }
            set
            {
                _pasaporte = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Idiomas
        {
            get
            {
                return _idiomas;
            }
            set
            {
                _idiomas = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LugarMatrimonio
        {
            get
            {
                return _lugarMatrimonio;
            }
            set
            {
                _lugarMatrimonio = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LugarNacimiento
        {
            get
            {
                return _lugarNacimiento;
            }
            set
            {
                _lugarNacimiento = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDTransporte
        {
            get
            {
                return _iDTransporte;
            }
            set
            {
                _iDTransporte = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Nacionalidad
        {
            get
            {
                return _nacionalidad;
            }
            set
            {
                _nacionalidad = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDTipovivienda
        {
            get
            {
                return _iDTipovivienda;
            }
            set
            {
                _iDTipovivienda = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDEstadonacimiento
        {
            get
            {
                return _iDEstadonacimiento;
            }
            set
            {
                _iDEstadonacimiento = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDMunicipionacimiento
        {
            get
            {
                return _iDMunicipionacimiento;
            }
            set
            {
                _iDMunicipionacimiento = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CursosAnteriores
        {
            get
            {
                return _cursosAnteriores;
            }
            set
            {
                _cursosAnteriores = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PuestosAnteriores
        {
            get
            {
                return _puestosAnteriores;
            }
            set
            {
                _puestosAnteriores = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? EstudiaActualmente
        {
            get
            {
                return _estudiaActualmente;
            }
            set
            {
                _estudiaActualmente = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HorarioEstudiante
        {
            get
            {
                return _horarioEstudiante;
            }
            set
            {
                _horarioEstudiante = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ZonaEconomica
        {
            get
            {
                return _zonaEconomica;
            }
            set
            {
                _zonaEconomica = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte[] Foto
        {
            get
            {
                return _foto;
            }
            set
            {
                _foto = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte[] Firma
        {
            get
            {
                return _firma;
            }
            set
            {
                _firma = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDPlantilla
        {
            get
            {
                return _iDPlantilla;
            }
            set
            {
                _iDPlantilla = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? IDJefedirecto
        {
            get
            {
                return _iDJefedirecto;
            }
            set
            {
                _iDJefedirecto = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? FechaIngreso
        {
            get
            {
                return _fechaIngreso;
            }
            set
            {
                _fechaIngreso = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? FechaBaja
        {
            get
            {
                return _fechaBaja;
            }
            set
            {
                _fechaBaja = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? FechaPrestaciones
        {
            get
            {
                return _fechaPrestaciones;
            }
            set
            {
                _fechaPrestaciones = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? FechaSigEvaluacion
        {
            get
            {
                return _fechaSigEvaluacion;
            }
            set
            {
                _fechaSigEvaluacion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? FechaInicioContrato
        {
            get
            {
                return _fechaInicioContrato;
            }
            set
            {
                _fechaInicioContrato = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? FechaVencContra
        {
            get
            {
                return _fechaVencContra;
            }
            set
            {
                _fechaVencContra = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDPatron
        {
            get
            {
                return _iDPatron;
            }
            set
            {
                _iDPatron = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDTabulador
        {
            get
            {
                return _iDTabulador;
            }
            set
            {
                _iDTabulador = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDPrestaciones
        {
            get
            {
                return _iDPrestaciones;
            }
            set
            {
                _iDPrestaciones = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? SalarioTabulador
        {
            get
            {
                return _salarioTabulador;
            }
            set
            {
                _salarioTabulador = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? SalarioIntegradoAnterior
        {
            get
            {
                return _salarioIntegradoAnterior;
            }
            set
            {
                _salarioIntegradoAnterior = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? SalarioDiarioAnterior
        {
            get
            {
                return _salarioDiarioAnterior;
            }
            set
            {
                _salarioDiarioAnterior = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? SalarioDiario
        {
            get
            {
                return _salarioDiario;
            }
            set
            {
                _salarioDiario = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? FactorIntegracion
        {
            get
            {
                return _factorIntegracion;
            }
            set
            {
                _factorIntegracion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? SalarioVariables
        {
            get
            {
                return _salarioVariables;
            }
            set
            {
                _salarioVariables = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDPuesto
        {
            get
            {
                return _iDPuesto;
            }
            set
            {
                _iDPuesto = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDTurno
        {
            get
            {
                return _iDTurno;
            }
            set
            {
                _iDTurno = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDDepartamento
        {
            get
            {
                return _iDDepartamento;
            }
            set
            {
                _iDDepartamento = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDCentrocosto
        {
            get
            {
                return _iDCentrocosto;
            }
            set
            {
                _iDCentrocosto = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDClasificacion
        {
            get
            {
                return _iDClasificacion;
            }
            set
            {
                _iDClasificacion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDSupervisor
        {
            get
            {
                return _iDSupervisor;
            }
            set
            {
                _iDSupervisor = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string PasswordPortal
        {
            get
            {
                return _passwordPortal;
            }
            set
            {
                _passwordPortal = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CreadoPor
        {
            get
            {
                return _creadoPor;
            }
            set
            {
                _creadoPor = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ModificadoPor
        {
            get
            {
                return _modificadoPor;
            }
            set
            {
                _modificadoPor = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? CreadoEn
        {
            get
            {
                return _creadoEn;
            }
            set
            {
                _creadoEn = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? ModificadoEn
        {
            get
            {
                return _modificadoEn;
            }
            set
            {
                _modificadoEn = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDRuta
        {
            get
            {
                return _iDRuta;
            }
            set
            {
                _iDRuta = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IDDelegacion
        {
            get
            {
                return _iDDelegacion;
            }
            set
            {
                _iDDelegacion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? SalarioPreIntegrado
        {
            get
            {
                return _salarioPreIntegrado;
            }
            set
            {
                _salarioPreIntegrado = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? SalarioTope
        {
            get
            {
                return _salarioTope;
            }
            set
            {
                _salarioTope = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string EstatusDescripcion
        {
            get
            {
                return _estatusDescripcion;
            }
            set
            {
                _estatusDescripcion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? Discapacidad
        {
            get
            {
                return _discapacidad;
            }
            set
            {
                _discapacidad = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public short? TipoDiscapacidad
        {
            get
            {
                return _tipoDiscapacidad;
            }
            set
            {
                _tipoDiscapacidad = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Institucion
        {
            get
            {
                return _institucion;
            }
            set
            {
                _institucion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public short? TipoInstitucion
        {
            get
            {
                return _tipoInstitucion;
            }
            set
            {
                _tipoInstitucion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CarreraTerminada
        {
            get
            {
                return _carreraTerminada;
            }
            set
            {
                _carreraTerminada = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public short? TipoDocProb
        {
            get
            {
                return _tipoDocProb;
            }
            set
            {
                _tipoDocProb = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public short? AnioEmision
        {
            get
            {
                return _anioEmision;
            }
            set
            {
                _anioEmision = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? SalarioPercepcionesFijas
        {
            get
            {
                return _salarioPercepcionesFijas;
            }
            set
            {
                _salarioPercepcionesFijas = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? SalarioIntegrado
        {
            get
            {
                return _salarioIntegrado;
            }
            set
            {
                _salarioIntegrado = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CuentaContable
        {
            get
            {
                return _cuentaContable;
            }
            set
            {
                _cuentaContable = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CuentaContable2
        {
            get
            {
                return _cuentaContable2;
            }
            set
            {
                _cuentaContable2 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? UsID
        {
            get
            {
                return _usID;
            }
            set
            {
                _usID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string NuevoPassword
        {
            get
            {
                return _nuevoPassword;
            }
            set
            {
                _nuevoPassword = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string ConfirmarContrasena
        {
            get
            {
                return _confirmarContrasena;
            }
            set
            {
                _confirmarContrasena = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string ConfirmarPassword
        {
            get
            {
                return _confirmarPassword;
            }
            set
            {
                _confirmarPassword = value;
            }
        }
        
        public static List<IXport.Data.Objects.Empleado> Select(
                    int? iDEmpleado, 
                    string nombreCompleto, 
                    string apellidoPaterno, 
                    string apellidoMaterno, 
                    string nombre, 
                    string rfc, 
                    DateTime? fechaResidencia, 
                    DateTime? fechaNacimiento, 
                    DateTime? fechaRevisionSalario, 
                    bool? multilingue, 
                    bool? pasaporte, 
                    string idiomas, 
                    string lugarMatrimonio, 
                    string lugarNacimiento, 
                    string iDTransporte, 
                    string nacionalidad, 
                    string iDTipovivienda, 
                    string iDEstadonacimiento, 
                    string iDMunicipionacimiento, 
                    string cursosAnteriores, 
                    string puestosAnteriores, 
                    bool? estudiaActualmente, 
                    string horarioEstudiante, 
                    string zonaEconomica, 
                    string iDPlantilla, 
                    int? iDJefedirecto, 
                    DateTime? fechaIngreso, 
                    DateTime? fechaBaja, 
                    DateTime? fechaPrestaciones, 
                    DateTime? fechaSigEvaluacion, 
                    DateTime? fechaInicioContrato, 
                    DateTime? fechaVencContra, 
                    string iDPatron, 
                    string iDTabulador, 
                    string iDPrestaciones, 
                    bool? salarioTabulador, 
                    decimal? salarioIntegradoAnterior, 
                    decimal? salarioDiarioAnterior, 
                    decimal? salarioDiario, 
                    decimal? factorIntegracion, 
                    decimal? salarioVariables, 
                    string iDPuesto, 
                    string iDTurno, 
                    string iDDepartamento, 
                    string iDCentrocosto, 
                    string iDClasificacion, 
                    string iDSupervisor, 
                    string passwordPortal, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string iDRuta, 
                    string iDDelegacion, 
                    decimal? salarioPreIntegrado, 
                    decimal? salarioTope, 
                    string estatusDescripcion, 
                    bool? discapacidad, 
                    short? tipoDiscapacidad, 
                    string institucion, 
                    short? tipoInstitucion, 
                    string carreraTerminada, 
                    short? tipoDocProb, 
                    short? anioEmision, 
                    decimal? salarioPercepcionesFijas, 
                    decimal? salarioIntegrado, 
                    string cuentaContable, 
                    string cuentaContable2, 
                    int? usID)
        {
            return new EmpleadoFactory().Select(iDEmpleado, nombreCompleto, apellidoPaterno, apellidoMaterno, nombre, rfc, fechaResidencia, fechaNacimiento, fechaRevisionSalario, multilingue, pasaporte, idiomas, lugarMatrimonio, lugarNacimiento, iDTransporte, nacionalidad, iDTipovivienda, iDEstadonacimiento, iDMunicipionacimiento, cursosAnteriores, puestosAnteriores, estudiaActualmente, horarioEstudiante, zonaEconomica, iDPlantilla, iDJefedirecto, fechaIngreso, fechaBaja, fechaPrestaciones, fechaSigEvaluacion, fechaInicioContrato, fechaVencContra, iDPatron, iDTabulador, iDPrestaciones, salarioTabulador, salarioIntegradoAnterior, salarioDiarioAnterior, salarioDiario, factorIntegracion, salarioVariables, iDPuesto, iDTurno, iDDepartamento, iDCentrocosto, iDClasificacion, iDSupervisor, passwordPortal, creadoPor, modificadoPor, creadoEn, modificadoEn, iDRuta, iDDelegacion, salarioPreIntegrado, salarioTope, estatusDescripcion, discapacidad, tipoDiscapacidad, institucion, tipoInstitucion, carreraTerminada, tipoDocProb, anioEmision, salarioPercepcionesFijas, salarioIntegrado, cuentaContable, cuentaContable2, usID);
        }
        
        public static List<IXport.Data.Objects.Empleado> Select(IXport.Data.Objects.Empleado qbe)
        {
            return new EmpleadoFactory().Select(qbe);
        }
        
        public static List<IXport.Data.Objects.Empleado> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new EmpleadoFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<IXport.Data.Objects.Empleado> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new EmpleadoFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Empleado> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new EmpleadoFactory().Select(filter, sort, EmpleadoFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Empleado> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new EmpleadoFactory().Select(filter, sort, EmpleadoFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<IXport.Data.Objects.Empleado> Select(string filter, BusinessObjectParameters parameters)
        {
            return new EmpleadoFactory().Select(filter, null, EmpleadoFactory.SelectView, parameters);
        }
        
        public static List<IXport.Data.Objects.Empleado> Select(string filter, params FieldValue[] parameters)
        {
            return new EmpleadoFactory().Select(filter, null, EmpleadoFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Empleado SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new EmpleadoFactory().SelectSingle(filter, parameters);
        }
        
        public static IXport.Data.Objects.Empleado SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new EmpleadoFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static IXport.Data.Objects.Empleado SelectSingle(int? iDEmpleado)
        {
            return new EmpleadoFactory().SelectSingle(iDEmpleado);
        }
        
        public int Insert()
        {
            return new EmpleadoFactory().Insert(this);
        }
        
        public int Update()
        {
            return new EmpleadoFactory().Update(this);
        }
        
        public int Delete()
        {
            return new EmpleadoFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("IDEmpleado: {0}", this.IDEmpleado);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class EmpleadoFactory
    {
        
        public EmpleadoFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Empleado");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Empleado");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Empleado");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Empleado");
            }
        }
        
        public static EmpleadoFactory Create()
        {
            return new EmpleadoFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? iDEmpleado, 
                    string nombreCompleto, 
                    string apellidoPaterno, 
                    string apellidoMaterno, 
                    string nombre, 
                    string rfc, 
                    DateTime? fechaResidencia, 
                    DateTime? fechaNacimiento, 
                    DateTime? fechaRevisionSalario, 
                    bool? multilingue, 
                    bool? pasaporte, 
                    string idiomas, 
                    string lugarMatrimonio, 
                    string lugarNacimiento, 
                    string iDTransporte, 
                    string nacionalidad, 
                    string iDTipovivienda, 
                    string iDEstadonacimiento, 
                    string iDMunicipionacimiento, 
                    string cursosAnteriores, 
                    string puestosAnteriores, 
                    bool? estudiaActualmente, 
                    string horarioEstudiante, 
                    string zonaEconomica, 
                    string iDPlantilla, 
                    int? iDJefedirecto, 
                    DateTime? fechaIngreso, 
                    DateTime? fechaBaja, 
                    DateTime? fechaPrestaciones, 
                    DateTime? fechaSigEvaluacion, 
                    DateTime? fechaInicioContrato, 
                    DateTime? fechaVencContra, 
                    string iDPatron, 
                    string iDTabulador, 
                    string iDPrestaciones, 
                    bool? salarioTabulador, 
                    decimal? salarioIntegradoAnterior, 
                    decimal? salarioDiarioAnterior, 
                    decimal? salarioDiario, 
                    decimal? factorIntegracion, 
                    decimal? salarioVariables, 
                    string iDPuesto, 
                    string iDTurno, 
                    string iDDepartamento, 
                    string iDCentrocosto, 
                    string iDClasificacion, 
                    string iDSupervisor, 
                    string passwordPortal, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string iDRuta, 
                    string iDDelegacion, 
                    decimal? salarioPreIntegrado, 
                    decimal? salarioTope, 
                    string estatusDescripcion, 
                    bool? discapacidad, 
                    short? tipoDiscapacidad, 
                    string institucion, 
                    short? tipoInstitucion, 
                    string carreraTerminada, 
                    short? tipoDocProb, 
                    short? anioEmision, 
                    decimal? salarioPercepcionesFijas, 
                    decimal? salarioIntegrado, 
                    string cuentaContable, 
                    string cuentaContable2, 
                    int? usID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iDEmpleado.HasValue)
            	filter.Add(("IDEmpleado:=" + iDEmpleado.Value.ToString()));
            if (!(String.IsNullOrEmpty(nombreCompleto)))
            	filter.Add(("NombreCompleto:*" + nombreCompleto));
            if (!(String.IsNullOrEmpty(apellidoPaterno)))
            	filter.Add(("ApellidoPaterno:*" + apellidoPaterno));
            if (!(String.IsNullOrEmpty(apellidoMaterno)))
            	filter.Add(("ApellidoMaterno:*" + apellidoMaterno));
            if (!(String.IsNullOrEmpty(nombre)))
            	filter.Add(("Nombre:*" + nombre));
            if (!(String.IsNullOrEmpty(rfc)))
            	filter.Add(("Rfc:*" + rfc));
            if (fechaResidencia.HasValue)
            	filter.Add(("FechaResidencia:=" + fechaResidencia.Value.ToString()));
            if (fechaNacimiento.HasValue)
            	filter.Add(("FechaNacimiento:=" + fechaNacimiento.Value.ToString()));
            if (fechaRevisionSalario.HasValue)
            	filter.Add(("FechaRevisionSalario:=" + fechaRevisionSalario.Value.ToString()));
            if (multilingue.HasValue)
            	filter.Add(("Multilingue:=" + multilingue.Value.ToString()));
            if (pasaporte.HasValue)
            	filter.Add(("Pasaporte:=" + pasaporte.Value.ToString()));
            if (!(String.IsNullOrEmpty(idiomas)))
            	filter.Add(("Idiomas:*" + idiomas));
            if (!(String.IsNullOrEmpty(lugarMatrimonio)))
            	filter.Add(("LugarMatrimonio:*" + lugarMatrimonio));
            if (!(String.IsNullOrEmpty(lugarNacimiento)))
            	filter.Add(("LugarNacimiento:*" + lugarNacimiento));
            if (!(String.IsNullOrEmpty(iDTransporte)))
            	filter.Add(("IDTransporte:*" + iDTransporte));
            if (!(String.IsNullOrEmpty(nacionalidad)))
            	filter.Add(("Nacionalidad:*" + nacionalidad));
            if (!(String.IsNullOrEmpty(iDTipovivienda)))
            	filter.Add(("IDTipovivienda:*" + iDTipovivienda));
            if (!(String.IsNullOrEmpty(iDEstadonacimiento)))
            	filter.Add(("IDEstadonacimiento:*" + iDEstadonacimiento));
            if (!(String.IsNullOrEmpty(iDMunicipionacimiento)))
            	filter.Add(("IDMunicipionacimiento:*" + iDMunicipionacimiento));
            if (!(String.IsNullOrEmpty(cursosAnteriores)))
            	filter.Add(("CursosAnteriores:*" + cursosAnteriores));
            if (!(String.IsNullOrEmpty(puestosAnteriores)))
            	filter.Add(("PuestosAnteriores:*" + puestosAnteriores));
            if (estudiaActualmente.HasValue)
            	filter.Add(("EstudiaActualmente:=" + estudiaActualmente.Value.ToString()));
            if (!(String.IsNullOrEmpty(horarioEstudiante)))
            	filter.Add(("HorarioEstudiante:*" + horarioEstudiante));
            if (!(String.IsNullOrEmpty(zonaEconomica)))
            	filter.Add(("ZonaEconomica:*" + zonaEconomica));
            if (!(String.IsNullOrEmpty(iDPlantilla)))
            	filter.Add(("IDPlantilla:*" + iDPlantilla));
            if (iDJefedirecto.HasValue)
            	filter.Add(("IDJefedirecto:=" + iDJefedirecto.Value.ToString()));
            if (fechaIngreso.HasValue)
            	filter.Add(("FechaIngreso:=" + fechaIngreso.Value.ToString()));
            if (fechaBaja.HasValue)
            	filter.Add(("FechaBaja:=" + fechaBaja.Value.ToString()));
            if (fechaPrestaciones.HasValue)
            	filter.Add(("FechaPrestaciones:=" + fechaPrestaciones.Value.ToString()));
            if (fechaSigEvaluacion.HasValue)
            	filter.Add(("FechaSigEvaluacion:=" + fechaSigEvaluacion.Value.ToString()));
            if (fechaInicioContrato.HasValue)
            	filter.Add(("FechaInicioContrato:=" + fechaInicioContrato.Value.ToString()));
            if (fechaVencContra.HasValue)
            	filter.Add(("FechaVencContra:=" + fechaVencContra.Value.ToString()));
            if (!(String.IsNullOrEmpty(iDPatron)))
            	filter.Add(("IDPatron:*" + iDPatron));
            if (!(String.IsNullOrEmpty(iDTabulador)))
            	filter.Add(("IDTabulador:*" + iDTabulador));
            if (!(String.IsNullOrEmpty(iDPrestaciones)))
            	filter.Add(("IDPrestaciones:*" + iDPrestaciones));
            if (salarioTabulador.HasValue)
            	filter.Add(("SalarioTabulador:=" + salarioTabulador.Value.ToString()));
            if (salarioIntegradoAnterior.HasValue)
            	filter.Add(("SalarioIntegradoAnterior:=" + salarioIntegradoAnterior.Value.ToString()));
            if (salarioDiarioAnterior.HasValue)
            	filter.Add(("SalarioDiarioAnterior:=" + salarioDiarioAnterior.Value.ToString()));
            if (salarioDiario.HasValue)
            	filter.Add(("SalarioDiario:=" + salarioDiario.Value.ToString()));
            if (factorIntegracion.HasValue)
            	filter.Add(("FactorIntegracion:=" + factorIntegracion.Value.ToString()));
            if (salarioVariables.HasValue)
            	filter.Add(("SalarioVariables:=" + salarioVariables.Value.ToString()));
            if (!(String.IsNullOrEmpty(iDPuesto)))
            	filter.Add(("IDPuesto:*" + iDPuesto));
            if (!(String.IsNullOrEmpty(iDTurno)))
            	filter.Add(("IDTurno:*" + iDTurno));
            if (!(String.IsNullOrEmpty(iDDepartamento)))
            	filter.Add(("IDDepartamento:*" + iDDepartamento));
            if (!(String.IsNullOrEmpty(iDCentrocosto)))
            	filter.Add(("IDCentrocosto:*" + iDCentrocosto));
            if (!(String.IsNullOrEmpty(iDClasificacion)))
            	filter.Add(("IDClasificacion:*" + iDClasificacion));
            if (!(String.IsNullOrEmpty(iDSupervisor)))
            	filter.Add(("IDSupervisor:*" + iDSupervisor));
            if (!(String.IsNullOrEmpty(passwordPortal)))
            	filter.Add(("PasswordPortal:*" + passwordPortal));
            if (!(String.IsNullOrEmpty(creadoPor)))
            	filter.Add(("CreadoPor:*" + creadoPor));
            if (!(String.IsNullOrEmpty(modificadoPor)))
            	filter.Add(("ModificadoPor:*" + modificadoPor));
            if (creadoEn.HasValue)
            	filter.Add(("CreadoEn:=" + creadoEn.Value.ToString()));
            if (modificadoEn.HasValue)
            	filter.Add(("ModificadoEn:=" + modificadoEn.Value.ToString()));
            if (!(String.IsNullOrEmpty(iDRuta)))
            	filter.Add(("IDRuta:*" + iDRuta));
            if (!(String.IsNullOrEmpty(iDDelegacion)))
            	filter.Add(("IDDelegacion:*" + iDDelegacion));
            if (salarioPreIntegrado.HasValue)
            	filter.Add(("SalarioPreIntegrado:=" + salarioPreIntegrado.Value.ToString()));
            if (salarioTope.HasValue)
            	filter.Add(("SalarioTope:=" + salarioTope.Value.ToString()));
            if (!(String.IsNullOrEmpty(estatusDescripcion)))
            	filter.Add(("EstatusDescripcion:*" + estatusDescripcion));
            if (discapacidad.HasValue)
            	filter.Add(("Discapacidad:=" + discapacidad.Value.ToString()));
            if (tipoDiscapacidad.HasValue)
            	filter.Add(("TipoDiscapacidad:=" + tipoDiscapacidad.Value.ToString()));
            if (!(String.IsNullOrEmpty(institucion)))
            	filter.Add(("Institucion:*" + institucion));
            if (tipoInstitucion.HasValue)
            	filter.Add(("TipoInstitucion:=" + tipoInstitucion.Value.ToString()));
            if (!(String.IsNullOrEmpty(carreraTerminada)))
            	filter.Add(("CarreraTerminada:*" + carreraTerminada));
            if (tipoDocProb.HasValue)
            	filter.Add(("TipoDocProb:=" + tipoDocProb.Value.ToString()));
            if (anioEmision.HasValue)
            	filter.Add(("AnioEmision:=" + anioEmision.Value.ToString()));
            if (salarioPercepcionesFijas.HasValue)
            	filter.Add(("SalarioPercepcionesFijas:=" + salarioPercepcionesFijas.Value.ToString()));
            if (salarioIntegrado.HasValue)
            	filter.Add(("SalarioIntegrado:=" + salarioIntegrado.Value.ToString()));
            if (!(String.IsNullOrEmpty(cuentaContable)))
            	filter.Add(("CuentaContable:*" + cuentaContable));
            if (!(String.IsNullOrEmpty(cuentaContable2)))
            	filter.Add(("CuentaContable2:*" + cuentaContable2));
            if (usID.HasValue)
            	filter.Add(("UsID:=" + usID.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<IXport.Data.Objects.Empleado> Select(
                    int? iDEmpleado, 
                    string nombreCompleto, 
                    string apellidoPaterno, 
                    string apellidoMaterno, 
                    string nombre, 
                    string rfc, 
                    DateTime? fechaResidencia, 
                    DateTime? fechaNacimiento, 
                    DateTime? fechaRevisionSalario, 
                    bool? multilingue, 
                    bool? pasaporte, 
                    string idiomas, 
                    string lugarMatrimonio, 
                    string lugarNacimiento, 
                    string iDTransporte, 
                    string nacionalidad, 
                    string iDTipovivienda, 
                    string iDEstadonacimiento, 
                    string iDMunicipionacimiento, 
                    string cursosAnteriores, 
                    string puestosAnteriores, 
                    bool? estudiaActualmente, 
                    string horarioEstudiante, 
                    string zonaEconomica, 
                    string iDPlantilla, 
                    int? iDJefedirecto, 
                    DateTime? fechaIngreso, 
                    DateTime? fechaBaja, 
                    DateTime? fechaPrestaciones, 
                    DateTime? fechaSigEvaluacion, 
                    DateTime? fechaInicioContrato, 
                    DateTime? fechaVencContra, 
                    string iDPatron, 
                    string iDTabulador, 
                    string iDPrestaciones, 
                    bool? salarioTabulador, 
                    decimal? salarioIntegradoAnterior, 
                    decimal? salarioDiarioAnterior, 
                    decimal? salarioDiario, 
                    decimal? factorIntegracion, 
                    decimal? salarioVariables, 
                    string iDPuesto, 
                    string iDTurno, 
                    string iDDepartamento, 
                    string iDCentrocosto, 
                    string iDClasificacion, 
                    string iDSupervisor, 
                    string passwordPortal, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string iDRuta, 
                    string iDDelegacion, 
                    decimal? salarioPreIntegrado, 
                    decimal? salarioTope, 
                    string estatusDescripcion, 
                    bool? discapacidad, 
                    short? tipoDiscapacidad, 
                    string institucion, 
                    short? tipoInstitucion, 
                    string carreraTerminada, 
                    short? tipoDocProb, 
                    short? anioEmision, 
                    decimal? salarioPercepcionesFijas, 
                    decimal? salarioIntegrado, 
                    string cuentaContable, 
                    string cuentaContable2, 
                    int? usID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDEmpleado, nombreCompleto, apellidoPaterno, apellidoMaterno, nombre, rfc, fechaResidencia, fechaNacimiento, fechaRevisionSalario, multilingue, pasaporte, idiomas, lugarMatrimonio, lugarNacimiento, iDTransporte, nacionalidad, iDTipovivienda, iDEstadonacimiento, iDMunicipionacimiento, cursosAnteriores, puestosAnteriores, estudiaActualmente, horarioEstudiante, zonaEconomica, iDPlantilla, iDJefedirecto, fechaIngreso, fechaBaja, fechaPrestaciones, fechaSigEvaluacion, fechaInicioContrato, fechaVencContra, iDPatron, iDTabulador, iDPrestaciones, salarioTabulador, salarioIntegradoAnterior, salarioDiarioAnterior, salarioDiario, factorIntegracion, salarioVariables, iDPuesto, iDTurno, iDDepartamento, iDCentrocosto, iDClasificacion, iDSupervisor, passwordPortal, creadoPor, modificadoPor, creadoEn, modificadoEn, iDRuta, iDDelegacion, salarioPreIntegrado, salarioTope, estatusDescripcion, discapacidad, tipoDiscapacidad, institucion, tipoInstitucion, carreraTerminada, tipoDocProb, anioEmision, salarioPercepcionesFijas, salarioIntegrado, cuentaContable, cuentaContable2, usID, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Empleado", dataView, request);
            return page.ToList<IXport.Data.Objects.Empleado>();
        }
        
        public List<IXport.Data.Objects.Empleado> Select(IXport.Data.Objects.Empleado qbe)
        {
            return Select(qbe.IDEmpleado, qbe.NombreCompleto, qbe.ApellidoPaterno, qbe.ApellidoMaterno, qbe.Nombre, qbe.Rfc, qbe.FechaResidencia, qbe.FechaNacimiento, qbe.FechaRevisionSalario, qbe.Multilingue, qbe.Pasaporte, qbe.Idiomas, qbe.LugarMatrimonio, qbe.LugarNacimiento, qbe.IDTransporte, qbe.Nacionalidad, qbe.IDTipovivienda, qbe.IDEstadonacimiento, qbe.IDMunicipionacimiento, qbe.CursosAnteriores, qbe.PuestosAnteriores, qbe.EstudiaActualmente, qbe.HorarioEstudiante, qbe.ZonaEconomica, qbe.IDPlantilla, qbe.IDJefedirecto, qbe.FechaIngreso, qbe.FechaBaja, qbe.FechaPrestaciones, qbe.FechaSigEvaluacion, qbe.FechaInicioContrato, qbe.FechaVencContra, qbe.IDPatron, qbe.IDTabulador, qbe.IDPrestaciones, qbe.SalarioTabulador, qbe.SalarioIntegradoAnterior, qbe.SalarioDiarioAnterior, qbe.SalarioDiario, qbe.FactorIntegracion, qbe.SalarioVariables, qbe.IDPuesto, qbe.IDTurno, qbe.IDDepartamento, qbe.IDCentrocosto, qbe.IDClasificacion, qbe.IDSupervisor, qbe.PasswordPortal, qbe.CreadoPor, qbe.ModificadoPor, qbe.CreadoEn, qbe.ModificadoEn, qbe.IDRuta, qbe.IDDelegacion, qbe.SalarioPreIntegrado, qbe.SalarioTope, qbe.EstatusDescripcion, qbe.Discapacidad, qbe.TipoDiscapacidad, qbe.Institucion, qbe.TipoInstitucion, qbe.CarreraTerminada, qbe.TipoDocProb, qbe.AnioEmision, qbe.SalarioPercepcionesFijas, qbe.SalarioIntegrado, qbe.CuentaContable, qbe.CuentaContable2, qbe.UsID);
        }
        
        public int SelectCount(
                    int? iDEmpleado, 
                    string nombreCompleto, 
                    string apellidoPaterno, 
                    string apellidoMaterno, 
                    string nombre, 
                    string rfc, 
                    DateTime? fechaResidencia, 
                    DateTime? fechaNacimiento, 
                    DateTime? fechaRevisionSalario, 
                    bool? multilingue, 
                    bool? pasaporte, 
                    string idiomas, 
                    string lugarMatrimonio, 
                    string lugarNacimiento, 
                    string iDTransporte, 
                    string nacionalidad, 
                    string iDTipovivienda, 
                    string iDEstadonacimiento, 
                    string iDMunicipionacimiento, 
                    string cursosAnteriores, 
                    string puestosAnteriores, 
                    bool? estudiaActualmente, 
                    string horarioEstudiante, 
                    string zonaEconomica, 
                    string iDPlantilla, 
                    int? iDJefedirecto, 
                    DateTime? fechaIngreso, 
                    DateTime? fechaBaja, 
                    DateTime? fechaPrestaciones, 
                    DateTime? fechaSigEvaluacion, 
                    DateTime? fechaInicioContrato, 
                    DateTime? fechaVencContra, 
                    string iDPatron, 
                    string iDTabulador, 
                    string iDPrestaciones, 
                    bool? salarioTabulador, 
                    decimal? salarioIntegradoAnterior, 
                    decimal? salarioDiarioAnterior, 
                    decimal? salarioDiario, 
                    decimal? factorIntegracion, 
                    decimal? salarioVariables, 
                    string iDPuesto, 
                    string iDTurno, 
                    string iDDepartamento, 
                    string iDCentrocosto, 
                    string iDClasificacion, 
                    string iDSupervisor, 
                    string passwordPortal, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string iDRuta, 
                    string iDDelegacion, 
                    decimal? salarioPreIntegrado, 
                    decimal? salarioTope, 
                    string estatusDescripcion, 
                    bool? discapacidad, 
                    short? tipoDiscapacidad, 
                    string institucion, 
                    short? tipoInstitucion, 
                    string carreraTerminada, 
                    short? tipoDocProb, 
                    short? anioEmision, 
                    decimal? salarioPercepcionesFijas, 
                    decimal? salarioIntegrado, 
                    string cuentaContable, 
                    string cuentaContable2, 
                    int? usID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(iDEmpleado, nombreCompleto, apellidoPaterno, apellidoMaterno, nombre, rfc, fechaResidencia, fechaNacimiento, fechaRevisionSalario, multilingue, pasaporte, idiomas, lugarMatrimonio, lugarNacimiento, iDTransporte, nacionalidad, iDTipovivienda, iDEstadonacimiento, iDMunicipionacimiento, cursosAnteriores, puestosAnteriores, estudiaActualmente, horarioEstudiante, zonaEconomica, iDPlantilla, iDJefedirecto, fechaIngreso, fechaBaja, fechaPrestaciones, fechaSigEvaluacion, fechaInicioContrato, fechaVencContra, iDPatron, iDTabulador, iDPrestaciones, salarioTabulador, salarioIntegradoAnterior, salarioDiarioAnterior, salarioDiario, factorIntegracion, salarioVariables, iDPuesto, iDTurno, iDDepartamento, iDCentrocosto, iDClasificacion, iDSupervisor, passwordPortal, creadoPor, modificadoPor, creadoEn, modificadoEn, iDRuta, iDDelegacion, salarioPreIntegrado, salarioTope, estatusDescripcion, discapacidad, tipoDiscapacidad, institucion, tipoInstitucion, carreraTerminada, tipoDocProb, anioEmision, salarioPercepcionesFijas, salarioIntegrado, cuentaContable, cuentaContable2, usID, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Empleado", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<IXport.Data.Objects.Empleado> Select(
                    int? iDEmpleado, 
                    string nombreCompleto, 
                    string apellidoPaterno, 
                    string apellidoMaterno, 
                    string nombre, 
                    string rfc, 
                    DateTime? fechaResidencia, 
                    DateTime? fechaNacimiento, 
                    DateTime? fechaRevisionSalario, 
                    bool? multilingue, 
                    bool? pasaporte, 
                    string idiomas, 
                    string lugarMatrimonio, 
                    string lugarNacimiento, 
                    string iDTransporte, 
                    string nacionalidad, 
                    string iDTipovivienda, 
                    string iDEstadonacimiento, 
                    string iDMunicipionacimiento, 
                    string cursosAnteriores, 
                    string puestosAnteriores, 
                    bool? estudiaActualmente, 
                    string horarioEstudiante, 
                    string zonaEconomica, 
                    string iDPlantilla, 
                    int? iDJefedirecto, 
                    DateTime? fechaIngreso, 
                    DateTime? fechaBaja, 
                    DateTime? fechaPrestaciones, 
                    DateTime? fechaSigEvaluacion, 
                    DateTime? fechaInicioContrato, 
                    DateTime? fechaVencContra, 
                    string iDPatron, 
                    string iDTabulador, 
                    string iDPrestaciones, 
                    bool? salarioTabulador, 
                    decimal? salarioIntegradoAnterior, 
                    decimal? salarioDiarioAnterior, 
                    decimal? salarioDiario, 
                    decimal? factorIntegracion, 
                    decimal? salarioVariables, 
                    string iDPuesto, 
                    string iDTurno, 
                    string iDDepartamento, 
                    string iDCentrocosto, 
                    string iDClasificacion, 
                    string iDSupervisor, 
                    string passwordPortal, 
                    string creadoPor, 
                    string modificadoPor, 
                    DateTime? creadoEn, 
                    DateTime? modificadoEn, 
                    string iDRuta, 
                    string iDDelegacion, 
                    decimal? salarioPreIntegrado, 
                    decimal? salarioTope, 
                    string estatusDescripcion, 
                    bool? discapacidad, 
                    short? tipoDiscapacidad, 
                    string institucion, 
                    short? tipoInstitucion, 
                    string carreraTerminada, 
                    short? tipoDocProb, 
                    short? anioEmision, 
                    decimal? salarioPercepcionesFijas, 
                    decimal? salarioIntegrado, 
                    string cuentaContable, 
                    string cuentaContable2, 
                    int? usID)
        {
            return Select(iDEmpleado, nombreCompleto, apellidoPaterno, apellidoMaterno, nombre, rfc, fechaResidencia, fechaNacimiento, fechaRevisionSalario, multilingue, pasaporte, idiomas, lugarMatrimonio, lugarNacimiento, iDTransporte, nacionalidad, iDTipovivienda, iDEstadonacimiento, iDMunicipionacimiento, cursosAnteriores, puestosAnteriores, estudiaActualmente, horarioEstudiante, zonaEconomica, iDPlantilla, iDJefedirecto, fechaIngreso, fechaBaja, fechaPrestaciones, fechaSigEvaluacion, fechaInicioContrato, fechaVencContra, iDPatron, iDTabulador, iDPrestaciones, salarioTabulador, salarioIntegradoAnterior, salarioDiarioAnterior, salarioDiario, factorIntegracion, salarioVariables, iDPuesto, iDTurno, iDDepartamento, iDCentrocosto, iDClasificacion, iDSupervisor, passwordPortal, creadoPor, modificadoPor, creadoEn, modificadoEn, iDRuta, iDDelegacion, salarioPreIntegrado, salarioTope, estatusDescripcion, discapacidad, tipoDiscapacidad, institucion, tipoInstitucion, carreraTerminada, tipoDocProb, anioEmision, salarioPercepcionesFijas, salarioIntegrado, cuentaContable, cuentaContable2, usID, null, Int32.MaxValue, 0, SelectView);
        }
        
        public IXport.Data.Objects.Empleado SelectSingle(int? iDEmpleado)
        {
            List<IXport.Data.Objects.Empleado> list = Select(iDEmpleado, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<IXport.Data.Objects.Empleado> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Empleado", dataView, request);
            return page.ToList<IXport.Data.Objects.Empleado>();
        }
        
        public List<IXport.Data.Objects.Empleado> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<IXport.Data.Objects.Empleado> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public IXport.Data.Objects.Empleado SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<IXport.Data.Objects.Empleado> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(IXport.Data.Objects.Empleado theEmpleado, IXport.Data.Objects.Empleado original_Empleado)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("IDEmpleado", original_Empleado.IDEmpleado, theEmpleado.IDEmpleado));
            values.Add(new FieldValue("NombreCompleto", original_Empleado.NombreCompleto, theEmpleado.NombreCompleto, true));
            values.Add(new FieldValue("ApellidoPaterno", original_Empleado.ApellidoPaterno, theEmpleado.ApellidoPaterno));
            values.Add(new FieldValue("ApellidoMaterno", original_Empleado.ApellidoMaterno, theEmpleado.ApellidoMaterno));
            values.Add(new FieldValue("Nombre", original_Empleado.Nombre, theEmpleado.Nombre));
            values.Add(new FieldValue("Rfc", original_Empleado.Rfc, theEmpleado.Rfc));
            values.Add(new FieldValue("FechaResidencia", original_Empleado.FechaResidencia, theEmpleado.FechaResidencia));
            values.Add(new FieldValue("FechaNacimiento", original_Empleado.FechaNacimiento, theEmpleado.FechaNacimiento));
            values.Add(new FieldValue("FechaRevisionSalario", original_Empleado.FechaRevisionSalario, theEmpleado.FechaRevisionSalario));
            values.Add(new FieldValue("Multilingue", original_Empleado.Multilingue, theEmpleado.Multilingue));
            values.Add(new FieldValue("Pasaporte", original_Empleado.Pasaporte, theEmpleado.Pasaporte));
            values.Add(new FieldValue("Idiomas", original_Empleado.Idiomas, theEmpleado.Idiomas));
            values.Add(new FieldValue("LugarMatrimonio", original_Empleado.LugarMatrimonio, theEmpleado.LugarMatrimonio));
            values.Add(new FieldValue("LugarNacimiento", original_Empleado.LugarNacimiento, theEmpleado.LugarNacimiento));
            values.Add(new FieldValue("IDTransporte", original_Empleado.IDTransporte, theEmpleado.IDTransporte));
            values.Add(new FieldValue("Nacionalidad", original_Empleado.Nacionalidad, theEmpleado.Nacionalidad));
            values.Add(new FieldValue("IDTipovivienda", original_Empleado.IDTipovivienda, theEmpleado.IDTipovivienda));
            values.Add(new FieldValue("IDEstadonacimiento", original_Empleado.IDEstadonacimiento, theEmpleado.IDEstadonacimiento));
            values.Add(new FieldValue("IDMunicipionacimiento", original_Empleado.IDMunicipionacimiento, theEmpleado.IDMunicipionacimiento));
            values.Add(new FieldValue("CursosAnteriores", original_Empleado.CursosAnteriores, theEmpleado.CursosAnteriores));
            values.Add(new FieldValue("PuestosAnteriores", original_Empleado.PuestosAnteriores, theEmpleado.PuestosAnteriores));
            values.Add(new FieldValue("EstudiaActualmente", original_Empleado.EstudiaActualmente, theEmpleado.EstudiaActualmente));
            values.Add(new FieldValue("HorarioEstudiante", original_Empleado.HorarioEstudiante, theEmpleado.HorarioEstudiante));
            values.Add(new FieldValue("ZonaEconomica", original_Empleado.ZonaEconomica, theEmpleado.ZonaEconomica));
            values.Add(new FieldValue("Foto", original_Empleado.Foto, theEmpleado.Foto));
            values.Add(new FieldValue("Firma", original_Empleado.Firma, theEmpleado.Firma));
            values.Add(new FieldValue("IDPlantilla", original_Empleado.IDPlantilla, theEmpleado.IDPlantilla));
            values.Add(new FieldValue("IDJefedirecto", original_Empleado.IDJefedirecto, theEmpleado.IDJefedirecto));
            values.Add(new FieldValue("FechaIngreso", original_Empleado.FechaIngreso, theEmpleado.FechaIngreso));
            values.Add(new FieldValue("FechaBaja", original_Empleado.FechaBaja, theEmpleado.FechaBaja));
            values.Add(new FieldValue("FechaPrestaciones", original_Empleado.FechaPrestaciones, theEmpleado.FechaPrestaciones));
            values.Add(new FieldValue("FechaSigEvaluacion", original_Empleado.FechaSigEvaluacion, theEmpleado.FechaSigEvaluacion));
            values.Add(new FieldValue("FechaInicioContrato", original_Empleado.FechaInicioContrato, theEmpleado.FechaInicioContrato));
            values.Add(new FieldValue("FechaVencContra", original_Empleado.FechaVencContra, theEmpleado.FechaVencContra));
            values.Add(new FieldValue("IDPatron", original_Empleado.IDPatron, theEmpleado.IDPatron));
            values.Add(new FieldValue("IDTabulador", original_Empleado.IDTabulador, theEmpleado.IDTabulador));
            values.Add(new FieldValue("IDPrestaciones", original_Empleado.IDPrestaciones, theEmpleado.IDPrestaciones));
            values.Add(new FieldValue("SalarioTabulador", original_Empleado.SalarioTabulador, theEmpleado.SalarioTabulador));
            values.Add(new FieldValue("SalarioIntegradoAnterior", original_Empleado.SalarioIntegradoAnterior, theEmpleado.SalarioIntegradoAnterior));
            values.Add(new FieldValue("SalarioDiarioAnterior", original_Empleado.SalarioDiarioAnterior, theEmpleado.SalarioDiarioAnterior));
            values.Add(new FieldValue("SalarioDiario", original_Empleado.SalarioDiario, theEmpleado.SalarioDiario));
            values.Add(new FieldValue("FactorIntegracion", original_Empleado.FactorIntegracion, theEmpleado.FactorIntegracion));
            values.Add(new FieldValue("SalarioVariables", original_Empleado.SalarioVariables, theEmpleado.SalarioVariables));
            values.Add(new FieldValue("IDPuesto", original_Empleado.IDPuesto, theEmpleado.IDPuesto));
            values.Add(new FieldValue("IDTurno", original_Empleado.IDTurno, theEmpleado.IDTurno));
            values.Add(new FieldValue("IDDepartamento", original_Empleado.IDDepartamento, theEmpleado.IDDepartamento));
            values.Add(new FieldValue("IDCentrocosto", original_Empleado.IDCentrocosto, theEmpleado.IDCentrocosto));
            values.Add(new FieldValue("IDClasificacion", original_Empleado.IDClasificacion, theEmpleado.IDClasificacion));
            values.Add(new FieldValue("IDSupervisor", original_Empleado.IDSupervisor, theEmpleado.IDSupervisor));
            values.Add(new FieldValue("PasswordPortal", original_Empleado.PasswordPortal, theEmpleado.PasswordPortal));
            values.Add(new FieldValue("CreadoPor", original_Empleado.CreadoPor, theEmpleado.CreadoPor));
            values.Add(new FieldValue("ModificadoPor", original_Empleado.ModificadoPor, theEmpleado.ModificadoPor));
            values.Add(new FieldValue("CreadoEn", original_Empleado.CreadoEn, theEmpleado.CreadoEn));
            values.Add(new FieldValue("ModificadoEn", original_Empleado.ModificadoEn, theEmpleado.ModificadoEn));
            values.Add(new FieldValue("IDRuta", original_Empleado.IDRuta, theEmpleado.IDRuta));
            values.Add(new FieldValue("IDDelegacion", original_Empleado.IDDelegacion, theEmpleado.IDDelegacion));
            values.Add(new FieldValue("SalarioPreIntegrado", original_Empleado.SalarioPreIntegrado, theEmpleado.SalarioPreIntegrado, true));
            values.Add(new FieldValue("SalarioTope", original_Empleado.SalarioTope, theEmpleado.SalarioTope));
            values.Add(new FieldValue("EstatusDescripcion", original_Empleado.EstatusDescripcion, theEmpleado.EstatusDescripcion, true));
            values.Add(new FieldValue("Discapacidad", original_Empleado.Discapacidad, theEmpleado.Discapacidad));
            values.Add(new FieldValue("TipoDiscapacidad", original_Empleado.TipoDiscapacidad, theEmpleado.TipoDiscapacidad));
            values.Add(new FieldValue("Institucion", original_Empleado.Institucion, theEmpleado.Institucion));
            values.Add(new FieldValue("TipoInstitucion", original_Empleado.TipoInstitucion, theEmpleado.TipoInstitucion));
            values.Add(new FieldValue("CarreraTerminada", original_Empleado.CarreraTerminada, theEmpleado.CarreraTerminada));
            values.Add(new FieldValue("TipoDocProb", original_Empleado.TipoDocProb, theEmpleado.TipoDocProb));
            values.Add(new FieldValue("AnioEmision", original_Empleado.AnioEmision, theEmpleado.AnioEmision));
            values.Add(new FieldValue("SalarioPercepcionesFijas", original_Empleado.SalarioPercepcionesFijas, theEmpleado.SalarioPercepcionesFijas));
            values.Add(new FieldValue("SalarioIntegrado", original_Empleado.SalarioIntegrado, theEmpleado.SalarioIntegrado, true));
            values.Add(new FieldValue("CuentaContable", original_Empleado.CuentaContable, theEmpleado.CuentaContable));
            values.Add(new FieldValue("CuentaContable2", original_Empleado.CuentaContable2, theEmpleado.CuentaContable2));
            values.Add(new FieldValue("UsID", original_Empleado.UsID, theEmpleado.UsID));
            values.Add(new FieldValue("NuevoPassword", original_Empleado.NuevoPassword, theEmpleado.NuevoPassword));
            values.Add(new FieldValue("ConfirmarContrasena", original_Empleado.ConfirmarContrasena, theEmpleado.ConfirmarContrasena));
            values.Add(new FieldValue("ConfirmarPassword", original_Empleado.ConfirmarPassword, theEmpleado.ConfirmarPassword));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(IXport.Data.Objects.Empleado theEmpleado, IXport.Data.Objects.Empleado original_Empleado, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Empleado";
            args.View = dataView;
            args.Values = CreateFieldValues(theEmpleado, original_Empleado);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Empleado", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theEmpleado);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(IXport.Data.Objects.Empleado theEmpleado, IXport.Data.Objects.Empleado original_Empleado)
        {
            return ExecuteAction(theEmpleado, original_Empleado, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(IXport.Data.Objects.Empleado theEmpleado)
        {
            return Update(theEmpleado, SelectSingle(theEmpleado.IDEmpleado));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(IXport.Data.Objects.Empleado theEmpleado)
        {
            return ExecuteAction(theEmpleado, new Empleado(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(IXport.Data.Objects.Empleado theEmpleado)
        {
            return ExecuteAction(theEmpleado, theEmpleado, "Select", "Delete", DeleteView);
        }
    }
}
