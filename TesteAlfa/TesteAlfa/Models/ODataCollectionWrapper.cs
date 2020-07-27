using System.Collections.Generic;

namespace TesteAlfa.Models
{
    public class ODataCollectionWrapper<T> where T : class
    {
        public IEnumerable<T> Value { get; set; }
    }
}
