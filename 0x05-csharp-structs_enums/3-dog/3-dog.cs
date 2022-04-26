using System;

enum Rating
{
    Good,
    Great,
    Excellent
}
struct Dog
{
    public Dog (string Name, float Age, string Owner, Rating Rating)
    {
        name = Name;
        age = Age;
        owner = Owner;
        rating = Rating;
    }

    public override string ToString()
    {
        return "Dog Name: " + name + "\n" +
               "Age: " + age + "\n" +
               "Owner: " + owner + "\n" +
               "Rating: " + rating;
    }

    public string name;
    public float age;
    public string owner;
    public Rating rating;
}
