using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Language_Courses.Models;

namespace Language_Courses
{
    public class DbInitializer
    {

        public static void Initialize(Context db)
        {
            db.Database.EnsureCreated();

            // Проверка занесены ли виды топлива
            if (db.Education.Any())
            {
                return;   // База данных инициализирована
            }

            int education_number = 35;
            int employes_number = 35;
            int listeners_number = 300;
            int courses_number = 300;
            int groups_number = 300;
            int payments_number = 300;
            string stage;
            string name;
            string surname;
            string patronymic;
            string voc = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            string voc_num = "1234567890";
            string position;


            Random randObj = new Random(1);

            string[] education_voc = { "Высшее", "Общее среднее", "Общее базовое", "Дошкольное" };//словарь названий образоываний
            int count_education_voc = education_voc.GetLength(0);
            for (int educationID = 1; educationID <= education_number; educationID++)
            {
                stage = education_voc[randObj.Next(count_education_voc)] + educationID.ToString();
                db.Education.Add(new Education { Stage = stage });
            }
            //сохранение изменений в базу данных, связанную с объектом контекста
            db.SaveChanges();

            for (int employeeID = 1; employeeID <= employes_number; employeeID++)
            {
                name = GenRandomString(voc, 10);
                surname = GenRandomString(voc, 15);
                patronymic = GenRandomString(voc, 15);

                position = GenRandomString(voc, 20);
                int educationID = randObj.Next(1, education_number - 1);
                db.Employes.Add(new Employee
                {
                    NameEmployee = name,
                    Surname = surname,
                    Patronymic = patronymic,
                    Position = position,
                    EducationID = educationID
                });
            }
            //сохранение изменений в базу данных, связанную с объектом контекста
            db.SaveChanges();


            for (int listenerID = 0; listenerID <= listeners_number; listenerID++)
            {
                string nameListener = GenRandomString(voc, 10);
                string surnameListener = GenRandomString(voc, 15);
                string patronymicListener = GenRandomString(voc, 15);
                DateTime today = DateTime.Now.Date;
                DateTime dateOfBirth = today.AddDays(-listenerID);
                string adress = GenRandomString(voc, 15);
                string phone = GenRandomString(voc_num, 6);
                string passportData = GenRandomString(voc, 150);
                db.Listeners.Add(new Listener
                {
                    NameListener = nameListener,
                    Surname = surnameListener,
                    Patronymic = patronymicListener,
                    DateOfBirth = dateOfBirth,
                    Adress = adress,
                    Phone = phone,
                    PassportData = passportData

                });
            }

            db.SaveChanges();

            for (int courseID = 1; courseID <= courses_number; courseID++)
            {
                int employeeID = randObj.Next(1, courses_number - 1);
                string nameCourse = GenRandomString(voc, 15);
                string trainingProgram = GenRandomString(voc, 20);
                string description = GenRandomString(voc, 20);
                string intensity = GenRandomString(voc, 20);
                int places = randObj.Next(10, 50);
                int hourse = randObj.Next(10, 100);
                decimal cost = randObj.Next(1000, 2000);

                db.Courses.Add(new Course
                {
                    EmployeeID = employeeID,
                    NameOfCourse = nameCourse,
                    TrainingProgram = trainingProgram,
                    DescriptionOfCourses = description,
                    IntensityOfTraining = intensity,
                    NumberOfPlaces = places,
                    Hourse = hourse,
                    Cost = cost
                });
            }
            db.SaveChanges();

            for (int paymentID = 1; paymentID <= payments_number; paymentID++)
            {
                int courseID = randObj.Next(1, courses_number - 1);
                int listenerID = randObj.Next(1, listeners_number - 1);
                DateTime today = DateTime.Now.Date;
                DateTime paymentDate = today.AddDays(-paymentID);
                int amount = randObj.Next(1000, 2000);
                db.Payments.Add(new Payment
                {
                    CourseId = courseID,
                    ListenerId = listenerID,
                    PaymentDate = paymentDate,
                    Amount = amount
                });
            }
            //сохранение изменений в базу данных, связанную с объектом контекста
            db.SaveChanges();


            for (int groupID = 1; groupID <= groups_number; groupID++)
            {
                int courseID = randObj.Next(1, courses_number - 1);
                int listenerID = randObj.Next(1, listeners_number - 1);
                db.Groups.Add(new Group
                {
                    CourseId = courseID,
                    ListenerId = listenerID
                });

            }
            db.SaveChanges();
        }

            static string GenRandomString(string Alphabet, int Length)
            {
                Random rnd = new Random();
                //объект StringBuilder с заранее заданным размером буфера под результирующую строку
                StringBuilder sb = new StringBuilder(Length - 1);
                //переменную для хранения случайной позиции символа из строки Alphabet
                int Position = 0;
                string ret = "";
                for (int i = 0; i < Length; i++)
                {
                    //получаем случайное число от 0 до последнего
                    //символа в строке Alphabet
                    Position = rnd.Next(0, Alphabet.Length - 1);
                    //добавляем выбранный символ в объект
                    //StringBuilder
                    ret = ret + Alphabet[Position];
                }
                return ret;
            }
    }
}

