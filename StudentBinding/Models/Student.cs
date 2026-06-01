namespace StudentBinding.Models;

public  class Student : ObservableObject
{
    private string name = string.Empty;
    private DateTime birthDate;
    private string email = string.Empty;
    private string phone = string.Empty;
    private string profileImage = string.Empty;

    public string Name
    {
        get => name;
        set
        {
            name = value;
            OnPropertyChanged();
        }
    }

    public int Age
    {
        get
        {
            int age = DateTime.Today.Year - BirthDate.Year;

            if (BirthDate.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }

    public DateTime BirthDate
    {
        get => birthDate;
        set
        {
            birthDate = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(Age));
        }
    }

    public string Email
    {
        get => email;
        set
        {
            email = value;
            OnPropertyChanged();
        }
    }

    public string Phone
    {
        get => phone;
        set
        {
            phone = value;
            OnPropertyChanged();
        }
    }

    public string ProfileImage
    {
        get => profileImage;
        set
        {
            profileImage = value;
            OnPropertyChanged();
        }
    }
}
