namespace TODO.WebApi.Models
{
    public class Book
    {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }
            public string CoverImage { get; set; }

            // Propiedades para calificaciones y reseñas
            public List<Reviews> Reviews { get; set; }

            // Calcula el promedio de calificaciones
            public double AverageRating
            {
                get
                {
                    if (Reviews != null && Reviews.Any())
                    {
                        return Reviews.Average(review => review.Rating);
                    }
                    return 0;  // Si no hay calificaciones, el promedio es 0
                }
            }

            public Book()
            {
                Title = string.Empty;
                Author = string.Empty;
                CoverImage = string.Empty;

                // Inicializar la lista de reseñas
                Reviews = new List<Reviews>();
            }
        
    }
}
