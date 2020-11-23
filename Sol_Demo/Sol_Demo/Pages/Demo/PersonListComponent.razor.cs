using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    public partial class PersonListComponent
    {
        #region Private  Property

        private List<PersonModel> PersonList { get; set; }

        #endregion Private  Property

        #region Private Method

        private Task<IReadOnlyList<PersonModel>> GetPersonDataAsync()
        {
            return Task.Run<IReadOnlyList<PersonModel>>(() =>
            {
                var personList = new List<PersonModel>();
                personList.Add(new PersonModel()
                {
                    FirstName = "Kishor",
                    LastName = "Naik"
                });
                personList.Add(new PersonModel()
                {
                    FirstName = "Eshaan",
                    LastName = "Naik"
                });

                return personList.AsReadOnly();
            });
        }

        #endregion Private Method

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                PersonList = (await this.GetPersonDataAsync()).ToList();
                base.StateHasChanged();
            }
        }
    }
}