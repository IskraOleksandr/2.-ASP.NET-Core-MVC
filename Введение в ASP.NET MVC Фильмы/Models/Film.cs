namespace Films_MVC
{
    public class Film
    { 
        public int Id { get; set; }// Идентификатор фильма
       
        public string Film_Name { get; set; }// Имя фильма
        
        public string Film_director { get; set; }// Режиссер фильма 

        public string Film_genre { get; set; }// Жанр фильма
        
        public string Year_of_issue { get; set; }//Год выхода фильма

        public string poster { get; set; }//Название постера фильма
       
        public string Short_description { get; set; } // Описание фильма
    }
}