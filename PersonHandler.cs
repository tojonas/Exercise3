namespace Exercise3
{
    public static class PersonHandler
    {
        public static Person CreatePerson(uint age, string fname, string lname, float height, float weight)
        {
            return new Person()
            {
                Age = age,
                FirstName = fname,
                LastName = lname,
                Height = height,
                Weight = weight
            };
        }

        public static Person SetAge( Person person, uint age )
        {
            Ensure.NotNull<Person>(person).Age = age;
            return person;
        }
        public static Person SetHeight(Person person, float height)
        {
            Ensure.NotNull<Person>(person).Height = height;
            return person;
        }
    }
}
