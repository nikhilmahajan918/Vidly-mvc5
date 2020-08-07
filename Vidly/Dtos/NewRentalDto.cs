using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }  /// <summary>
        /// here, we do not map the data in mapping profile,bcs unlike Moviedto and Customerdto..RentalDto uses its own prop.
        /// i.e CustomerId and MovieId,whereas in MovieDto and cUstomerDto,they uses Movie and Customer class prop.
        /// </summary>
        public List<int> MovieIds { get; set; } 
    }
}