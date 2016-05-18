using System;

namespace MVVMTestSample
{
	public class PersonRepository
	{
		private Person theOnlyPerson;

		public PersonRepository ()
		{
			theOnlyPerson = new Person () {
				Name = "Person Name Here",
				Updated = DateTime.Now.ToString ()
			};
		}

		public Person GetPerson (int id)
		{
			return theOnlyPerson;
		}

		public void Update (Person person)
		{
			theOnlyPerson = person;
		}

	}
}

