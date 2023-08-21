
using Microsoft.EntityFrameworkCore;

namespace Films_MVC
{
    public class FilmContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public FilmContext(DbContextOptions<FilmContext> options)
           : base(options)
        {
            if (Database.EnsureCreated())
            {
                Films.Add(new Film { Film_Name = "Интерстеллар", Film_director = "Кристофер Нолан", Film_genre = "фантастика, драма, приключения", Year_of_issue = "2014", poster = "~/Image/Interstellar.jpg", Short_description = "Когда засуха, пыльные бури и вымирание растений приводят человечество к продовольственному кризису, коллектив исследователей и учёных отправляется сквозь червоточину (которая предположительно соединяет области пространства-времени через большое расстояние) в путешествие, чтобы превзойти прежние ограничения для космических путешествий человека и найти планету с подходящими для человечества условиями." });
                Films.Add(new Film { Film_Name = "Властелин Колец: Братство Кольца", Film_director = "Питер Джексон", Film_genre = "драма, приключения, фэнтези", Year_of_issue = "2001", poster = "~/Image/The Lord of the Rings.jpg", Short_description = "Первая часть легендарной трилогии по романам Дж.Р.Р.Толкиена. Фродо Бэггинс отправляется в опасное путешествие, когда его дядя Бильбо решает уйти на покой и оставляет ему загадочное и манящее кольцо. Оно было выковано в недрах Ородруина злым чародеем Сауроном, чтобы обрести безграничную власть над миром. Теперь главная цель так называемого Братства кольца — уничтожить его любой ценой." });
                
                SaveChanges();
            }
        }
    }
}