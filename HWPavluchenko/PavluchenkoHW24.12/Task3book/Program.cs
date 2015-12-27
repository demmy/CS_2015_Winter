using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3book
{   //    Задание 3
    //Требуется:
    //Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать одно строковое поле 
    //    и метод void Show().
    //Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
    //Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
    class Program
    {
        static void Main(string[] args)
        {
            Book bo = new Book();
            Title tit = new Title();
            Author aut = new Author();
            Content cont = new Content();
            tit.Title1 = "Title text";
            aut.Author1 = "Author name";
            cont.Content1 = "Content text";
            tit.Show();
            aut.Show();
            cont.Show();
            bo.Add(tit.Title1, aut.Author1, cont.Content1);
            bo.Show();
        }
    }
}
