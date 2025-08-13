using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Consts
{
    public static class GlobalConstantMessages
    {
        #region Cliente
        public const string Api = "api/[controller]";
        public const string MSG_CGID_METHOD_DESC = "No se encontro algun registro coincidente con:";
        public const string MSG_REQUIRED = "Campo obligatorio.";
        public const string MSG_VALIDATION_EMAIL = "Formato de email inválido.";
        public const string MSG_VALIDATION_PHONE = "El teléfono debe tener exactamente 10 dígitos";
        #endregion
    }
}
