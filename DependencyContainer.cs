using ispat.IRepository;
//using ispat.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskList.IRepository;
using TaskList.Services;

namespace ispat
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<ICreate, CustomerRepo>();
            
            //  services.AddTransient<IAuthentication, Authentication>();



        }
    }
}

