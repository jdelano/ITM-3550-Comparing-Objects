using System;
namespace ComparingObjects2024
{
	public class Person : IEquatable<Person>
	{
		public string Name { get; set; } = string.Empty;
		public int Age { get; set; }
        public string Street { get; set; } = string.Empty;

        public bool Equals(Person? other)
        {
            if (other is null) return false;
            return Name == other.Name && Age == other.Age && Street == other.Street;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public override int GetHashCode()
        {
            return (Name + Age.ToString()).GetHashCode();
        }

        public static bool operator ==(Person rhs, Person lhs)
        {
            return rhs.Equals(lhs);
        }

        public static bool operator !=(Person rhs, Person lhs)
        {
            return !rhs.Equals(lhs);
        }

    }
}

