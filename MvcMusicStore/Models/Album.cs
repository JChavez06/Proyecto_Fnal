using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    public class Album
        {
        [ScaffoldColumn(false)]        public int AlbumId { get; set; }

        [DisplayName("Genero:")]        public int GenreId { get; set; }

        [DisplayName("Artista:")]        public int ArtistId { get; set; }

        [Required(ErrorMessage = "El album requiere un titulo")]
        [DisplayName("Titulo:")]
        [StringLength(160)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Precio requerido")]
        [Range(0.01, 100.00,
            ErrorMessage = "El precio debe ser entre 0.01 y 100.00")]
        public decimal Price { get; set; }

        [DisplayName("URL portada Album")]        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }

        public virtual Genre Genre { get; set; }        public virtual Artist Artist { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
}
}