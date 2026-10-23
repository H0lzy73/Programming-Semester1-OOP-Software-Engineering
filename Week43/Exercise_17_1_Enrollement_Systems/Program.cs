Student student1 = new Student("Tom", 1234);
Student student2 = new Student("om", 1434);
Course math = new Course("Math");
EnrollmentSystem enroll = new EnrollmentSystem();
//Console.WriteLine("test");
math.Enroll(student1);
math.Enroll(student2);
Console.WriteLine("test");
for (int i = 0; i<2; i++) {
    
    Student enrolled = math.GetParticipants()[i];
    Console.WriteLine(enrolled.name);
    
}

enroll.removeStudents(student1);
Console.WriteLine("test");

public class Student {
    public string name;
    public int id;
    public Student (string nameValue, int idValue) {
        name = nameValue;
        id = idValue;
    }
    public string GetName () {
    return name;
    }
}

public class Course {
    string name;
    Student[] participants;
    public Course (string nameValue) {
        name = nameValue;
        participants = new Student[10]; // NOTE: This constant is BAD!
    }
    
    public void Enroll (Student student) {
        for (int i=0 ; i<participants.Length ; i++) {
            if (participants[i] == null) {
                participants[i] = student;
                return;
            }
        }
    }
    
    public void Remove (Student student) {
        for (int i=0 ; i<participants.Length ; i++) {
            if (participants[i] == student) {
                participants[i] = null;
            }
        }
    }
    
    public Student[] GetParticipants () {
    // count number of entries
    int count = 0;
    foreach (Student student in participants) {
        if (student != null) {
            count++;
        }
    }
    
    // make a copy
    Student[] result = new Student[count];
    int index = 0;
    foreach (Student student in participants) {
        if (student != null) {
            result[index++] = student;
        }
    }
        return result;
    }
    }
    public class EnrollmentSystem
    {
    
    public Student[] students;
    public Course[] courses;
    public void Enroll(Student student, Course course) {
    course.Enroll(student);
    }
    public void Remove(Student student, Course course) {
    course.Remove(student);
    }
    public void ShowParticipants(Course course) {
    foreach (Student student in course.GetParticipants()) {
    Console.WriteLine(student.GetName());
    }
    }
    public void GetCourses() {
    Console.WriteLine("void for a getter?");
    }
    public void GetStudents() {
    Console.WriteLine("void for a getter?");
    }

    public void removeStudents(Student student) {
        foreach (Course course in courses) {
            if (course != null) {
                course.Remove(student);
            }
        }
    }
    public void AddStudent(Student student) {
        for (int i = 0; i < students.Length; i++) {
            if (students[i] == null) {
                students[i] = student;
                return;
            }
        }
    }
    
    public void AddCourse(Course course) {
        for (int i = 0; i < courses.Length; i++) {
            if (courses[i] == null) {
                courses[i] = course;
                return;
            }
        }
    }
    
    }
