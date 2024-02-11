using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class pttManager : ISupplierService
    {
        private IApplicantService _applicantService;
        public pttManager(IApplicantService applicantService) //Constuctor new yapıldığında çalışır
        {
            _applicantService = applicantService;
        }
            public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için make verildi");
            }
        }

    }
}
