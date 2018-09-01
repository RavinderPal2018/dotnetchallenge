using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetChallenge.Repo.Entities;
namespace DotnetChallenge.Repo
{
    public interface IPersonRepository
    {
        String ConvertCurrencyToWords(String numb);

        Person GetPerson(string name, string amount);
    }

}
