using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Task12PatternAndRelatedDataLoading.Pattern;

namespace Task12PatternAndRelatedDataLoading.Controllers
{
    public class PatternController : Controller
    {

        private readonly PatternClass _patternClass;

        public PatternController(IOptions<PatternClass> options)
        {
            _patternClass = options.Value;
        }
        public IActionResult Index()
        {
            var data = _patternClass;

            return Ok(_patternClass);
        }
    }
}
