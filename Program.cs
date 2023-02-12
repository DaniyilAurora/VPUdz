Console.WriteLine("Hello, World!");

var homeworks = new List<Homework>() {
    new Homework{StudentID = 1, TeacherID = 1, Subject = "C++", Description="Do Bubble Sort", Mark=10},
    new Homework{StudentID = 2, TeacherID = 2, Subject = "C#", Description="Do Website ASP.NET", Mark=9},
    new Homework{StudentID = 3, TeacherID = 1, Subject = "C++", Description="Write Own Unreal Engine", Mark=11},
    new Homework{StudentID = 4, TeacherID = 2, Subject = "C#", Description="Write Program for Rocket Falcon 9 SpaceX", Mark=12},
    new Homework{StudentID = 5, TeacherID = 3, Subject = "MySQL", Description="Write Program to manage databases for Facebook", Mark=10},
    new Homework{StudentID = 6, TeacherID = 2, Subject = "C#", Description="Colonize Mars using only C#", Mark=7}
};

List<Homework> homeworksOfStudent5 = homeworks.Where(homework => homework.StudentID == 5).ToList();

List<Homework> homeworksCpp = homeworks.Where(homework => homework.Subject == "C++").ToList();

List<Homework> homeworksSpecific = homeworks.Where(homework => homework.TeacherID == 1 && homework.Mark < 5).ToList();

Homework? homeworkSpecific = homeworks.FirstOrDefault(homework => homework.StudentID == 1 && homework.TeacherID == 6);

foreach (Homework hw in homeworksOfStudent5) {
    Console.WriteLine($"SID: {hw.StudentID} TID: {hw.TeacherID} SUB: {hw.Subject} DESC: {hw.Description} MARK: {hw.Mark}");
}