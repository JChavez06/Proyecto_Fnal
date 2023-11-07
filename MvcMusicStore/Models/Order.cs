using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    [Bind(Exclude = "OrderId")]
    public partial class Order
    {
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }

        [ScaffoldColumn(false)]
        public string Username { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [DisplayName("Nombre:")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [DisplayName("Apellido:")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "La dirección es requerida")]
        [DisplayName("Dirección:")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "la ciudad es requerida")]
        [DisplayName("Ciudad:")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        [DisplayName("Estado:")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "El codigo postal es requerido")]
        [DisplayName("Codigo postal:")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "El pais es requerido")]
        [DisplayName("Pais:")]
        [StringLength(40)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Numero de contacto requerido")]
        [DisplayName("Numero de contacto:")]
        [StringLength(24)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "El correo electronico es requerido")]
        [DisplayName("Correo Electronico:")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Correo electronico no valido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}