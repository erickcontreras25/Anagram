using AnagramsKata;
using Machine.Specifications;

namespace AnagramsKata.specs
{
    public class When_Receiving_Strings
    {
        private static Anagrams _anagrams;

        Establish context = () =>
        {
            _anagrams = new Anagrams("prueba", "abeurp");
        };

        It Should_equal_true = () => _anagrams.respuesta.ShouldEqual(true);    
    }
}