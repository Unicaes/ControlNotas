using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerUI.Model
{
    class Usuario
    {
        private int idUsuario, tipo, idAula;
        private String nombre, apellido, user, clave, telefono, direccion, representante, telefonoRepresentante, documento, documentoRepresentante;
        private DateTime fechaNacimiento;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Representante { get => representante; set => representante = value; }
        public string TelefonoRepresentante { get => telefonoRepresentante; set => telefonoRepresentante = value; }
        public string Documento { get => documento; set => documento = value; }
        public string DocumentoRepresentante { get => documentoRepresentante; set => documentoRepresentante = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Username { get => user; set => user = value; }
        public int IdAula { get => idAula; set => idAula = value; }
    }
}
