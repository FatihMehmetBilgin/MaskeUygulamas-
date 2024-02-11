using Business.Abstract;
using Entities.Concrete;
using MenrisServiceReference1;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {

        // Encapsulation= tüm özellikleri alıp bir clasn içen koymaya denir
        // çıplak class kalmasın
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> Getlist() // list<Person> personları listeler
        {
            return null;

        }
        public bool CheckPerson(Person person)
        {
            // mernis kontrolü yapılacak
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new
                (123,"","",1995))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
