using demoLibrary.Models;

namespace demoLibrary.DataAccess
{
    public interface IDataAccesss
    {
        List<PersonModel> getPeople();
        PersonModel InsertPerson(string firstName, string lastName);
    }
}