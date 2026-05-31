using StudentBinding.Models;

namespace StudentBinding.ViewModels;

public class MainPageViewModel : ViewModelBase
{
    private Student firstStudent;
    private Student secondStudent;
    private Student currentStudent;

    public MainPageViewModel()
    {
        firstStudent = new Student
        {
            Name = "Daniel Cohen",
            BirthDate = new DateTime(2008, 6, 1),
            Email = "daniel@gmail.com",
            Phone = "050-1111111",
            ProfileImage = "daniel.png"
        };

        secondStudent = new Student
        {
            Name = "Noa Levi",
            BirthDate = new DateTime(2008, 12, 10),
            Email = "noa@gmail.com",
            Phone = "050-2222222",
            ProfileImage = "noa.png"
        };

        currentStudent = firstStudent;
        SwitchStudentCommand = new Command(SwitchStudent);
    }

    public Student FirstStudent
    {
        get => firstStudent;
        set
        {
            firstStudent = value;
            OnPropertyChanged();
        }
    }

    public Student SecondStudent
    {
        get => secondStudent;
        set
        {
            secondStudent = value;
            OnPropertyChanged();
        }
    }

    public Student CurrentStudent
    {
        get => currentStudent;
        set
        {
            currentStudent = value;
            OnPropertyChanged();
        }
    }

    public Command SwitchStudentCommand { get; }

    private void SwitchStudent()
    {
        if (CurrentStudent == FirstStudent)
        {
            CurrentStudent = SecondStudent;
        }
        else
        {
            CurrentStudent = FirstStudent;
        }
    }
}
