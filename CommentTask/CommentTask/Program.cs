using Core;
using Core.Models;

namespace CommentTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blog blog = new Blog();
            string answer;
            do 
            {


                Console.WriteLine("1.Blog yarat\n" +
                    "0.Programdan cixin");
                Console.Write("Bir secim edin: ");
                answer = Console.ReadLine();

                if (answer == "1")
                {
                    bool check;
                    string title;
                    string description;
                    do
                    {
                        Console.Write("Blogun titleni daxil edin: ");
                        title = Console.ReadLine();
                        check = Helper.CheckBlogTitle(title);

                    } while (!check);
                    do
                    {
                        Console.Write("Blogun description daxil edin: ");
                         description = Console.ReadLine();
                        check = Helper.CheckBlogDescription(description);

                        
                       

                    } while (!check);

                    Blog blog1 = new Blog(title,description);
                    
                    
                    string choice;


                    do
                    {

                        Console.WriteLine(" 1.1 Comment yarat.\n" +
                            "1.2 Commentlere bax\n" +
                            "1.3 Commente bax\n" +
                            "1.4 Commenti sil\n" +
                            "1.5 Commenti deyiş (update)\n" +
                            "0. Ana menyuya qayıt");
                        Console.Write("Bir secim edin: ");
                        choice = Console.ReadLine();
                        if(choice == "1") 
                        {
                            Console.Write("Content daxil edin: ");
                            string content = Console.ReadLine();

                            Comment comment = new Comment(content);

                            blog.AddComment(comment);


                        }
                        if(choice == "2")
                        {
                            foreach(var item in blog.GetAllComments())
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }
                        if(choice == "3")
                        {
                            int id;
                            do
                            {
                                Console.Write("Id daxil edin: ");

                            } while (!int.TryParse(Console.ReadLine(), out id));



                            Console.WriteLine(blog.GetComment(id));





                        }
                        if(choice == "4")
                        {
                            int id;
                            do
                            {
                                Console.Write("Id daxil edin: ");

                            } while (!int.TryParse(Console.ReadLine(), out id));

                            foreach(var item in blog.RemoveComment(id))
                            {
                                Console.WriteLine(item.ToString());
                            }


                            


                        }
                        if(choice == "5")
                        {
                            int id;
                            do
                            {
                                Console.Write("Id daxil edin: ");

                            } while (!int.TryParse(Console.ReadLine(), out id));

                            Console.Write("Content daxil edin: ");
                            string content = Console.ReadLine();

                            Comment comment1 = new Comment(content);



                            foreach (var item in blog.UptadeComment(id,comment1))
                            {
                                Console.WriteLine(item);
                            }

                        }

                    } while (choice != "0");


                }


             } 
            
            while (answer != "0");
        }
    }
}
