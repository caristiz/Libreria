namespace TODO.WebApi.Models
{
    public class Reviews
    {
       
            public int Id { get; set; }
            public int BookId { get; set; }  // ID del libro asociado a esta reseña
            public int UserId { get; set; }  // ID del usuario que escribió la reseña
            public int Rating { get; set; } = 0;  // Puntuación (por ejemplo, de 1 a 5 estrellas) con valor predeterminado
            public string Comment { get; set; } = string.Empty;  // Comentario de la reseña con valor predeterminado
            public DateTime Date { get; set; } = DateTime.Now;  // Fecha de la reseña con valor predeterminado

            // Puedes agregar más propiedades según tus necesidades

            // Relación con el libro
            public Book? Book { get; set; }  // Marcamos Book como nullable (?)

            // Relación con el usuario
            public User? User { get; set; }  // Marcamos User como nullable (?)
        
    }
}
