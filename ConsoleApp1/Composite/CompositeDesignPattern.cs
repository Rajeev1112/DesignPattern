using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Composite
{
    class Client
    {
        public void Execute()
        {
            var patientDetails = new List<PatientDataModel>()
            {
                new PatientDataModel()
                {
                    Name = "Patient1",
                    Age = 20,
                    ContactNumber = "12345678",
                    Mrn = "MR001"
                },
                new PatientDataModel()
                {
                    Name = "Patient2",
                    Age = 65,
                    ContactNumber = "87937676",
                    Mrn = "MR002"
                }
            };

            PatientDataFilterService patientDataFilterService = new PatientDataFilterService(patientDetails
            );

            var filter1 = new SearchByMrn();
            filter1.SetMrn("MR001");

            var filter2 = new SearchByName();
            filter2.SetName("Patient2");

            foreach (var patient in patientDataFilterService.Search(filter1))
            {
                Console.WriteLine($"Patient Details - Name : {patient.Name}, Mrn : {patient.Mrn}, ContactNumber : {patient.ContactNumber}");
            }

            PatientDataFilterServiceComposite composite = new PatientDataFilterServiceComposite(patientDetails);
            composite.AddFilter(filter1);
            composite.AddFilter(filter2);

            foreach (var patient in composite.Search())
            {
                Console.WriteLine($"Patient Details - Name : {patient.Name}, Mrn : {patient.Mrn}, ContactNumber : {patient.ContactNumber}");
            }

            Console.ReadLine();
        }
    }

    class PatientDataFilterService
    {
        private readonly IList<PatientDataModel> _patientData;

        public PatientDataFilterService(IList<PatientDataModel> patientData)
        {
            _patientData = patientData;
        }

        public IList<PatientDataModel> Search(IFilterService filterObject)
        {
            return filterObject.Filter(_patientData);
        }

    }

    class PatientDataFilterServiceComposite
    {
        private readonly IList<PatientDataModel> _patientData;
        private IList<IFilterService> filterList = new List<IFilterService>();

        public PatientDataFilterServiceComposite(IList<PatientDataModel> patientData)
        {
            _patientData = patientData;
        }

        public IList<PatientDataModel> Search()
        {

            foreach (var filterService in filterList)
            {
                _patientData.ToList().AddRange(filterService.Filter(_patientData));
            }

            return _patientData;
        }

        public void AddFilter(IFilterService filter)
        {
            filterList.Add(filter);
        }

        public void RemoveFilter(IFilterService filter)
        {
            filterList.Remove(filter);
        }

    }

    class PatientDataModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mrn { get; set; }
        public string ContactNumber { get; set; }
    }

    interface IFilterService
    {
        IList<PatientDataModel> Filter(IList<PatientDataModel> patientData);
    }

    class SearchByMrn : IFilterService
    {
        private string mrn;
        public IList<PatientDataModel> Filter(IList<PatientDataModel> patientData)
        {
            return patientData.Where(p => p.Mrn == mrn).ToList();
        }

        public void SetMrn(string Mrn)
        {
            mrn = Mrn;
        }
    }

    class SearchByName : IFilterService
    {
        private string name;
        public IList<PatientDataModel> Filter(IList<PatientDataModel> patientData)
        {
            return patientData.Where(p => p.Name == name).ToList();
        }

        public void SetName(string Name)
        {
            name = Name;
        }
    }

    class SearchByContactNumber : IFilterService
    {
        private string contactNumber;
        public IList<PatientDataModel> Filter(IList<PatientDataModel> patientData)
        {
            return patientData.Where(p => p.ContactNumber == contactNumber).ToList();
        }

        public void SetContactNumber(string ContactNumber)
        {
            contactNumber = ContactNumber;
        }
    }
}
