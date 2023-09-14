using Challgeapp;

Employee employee1 = new Employee("Jan", "Sam", 33);
Employee employee2 = new Employee("Damian", "Sam", 34);
Employee employee3 = new Employee("Ewa", "Sam", 31);

employee1.AddScore(9);
employee1.AddScore(6);
employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(6);

employee1.AddScore(9);
employee1.AddScore(8);
employee1.AddScore(7);
employee1.AddScore(6);
employee1.AddScore(4);

employee1.AddScore(9);
employee1.AddScore(6);
employee1.AddScore(4);
employee1.AddScore(8);
employee1.AddScore(4);

List<Employee> users = new List<Employee>()
{
employee1, employee2, employee3

};
var maxScore = users.Max(e => e.pointsOfEmployee);
var maxScore2 = 0;
Employee userMaxScore = null;
foreach (var user in users)
    NewMethod(maxScore, ref maxScore2, ref userMaxScore, user);

static void NewMethod(int maxScore, ref int maxScore2, ref Employee userMaxScore, Employee user)
{
    if (user.pointsOfEmployee > maxScore)
    {
        maxScore2 = user.pointsOfEmployee;
        userMaxScore = user;


    }
    Console.WriteLine($"Employee with max score is {userMaxScore.name},{userMaxScore.lastName},{userMaxScore.age} years old, his score is {maxScore2}");
    Console.WriteLine($"{maxScore}");
}