//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoPrograV
{
    using System;
    using System.Collections.Generic;
    
    public partial class Matricula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matricula()
        {
            this.Asistencias = new HashSet<Asistencia>();
        }
    
        public byte Numero_Grupo { get; set; }
        public string Tipo_Matricula { get; set; }
        public string Tipo_ID_Estudiante { get; set; }
        public string Identificacion_Estudiante { get; set; }
        public Nullable<double> Nota { get; set; }
        public string Codigo_Curso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asistencia> Asistencias { get; set; }
        public virtual Estudiante Estudiante { get; set; }
        public virtual Grupos Grupos { get; set; }
    }
}
