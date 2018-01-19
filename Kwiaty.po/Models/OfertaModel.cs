using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kwiaty.po.Models
{
    public class OfertaModel
    {
        public List<ProduktModel> ProduktyWOfercie;

        internal static OfertaModel ExampleOffer()
        {
            List<ProduktModel> example = new List<ProduktModel>();
            example.Add(new ProduktModel(175.00, "Kwiaty dla Babci", "kw_babcia.jpg", "Niezwykły prezent dla Babci i Dziadka! Ten unikatowy bukiet z Biovitalem sprawi radość i niezapomniane wrażenia. Sprawdź to już teraz i wyślij kwiaty w dowolne miejsce w Polsce."));
            example.Add(new ProduktModel(149.00, "Bukiet Impresja", "kw_impresja.jpg", "Impresjoniści dążyli do bliskości z naturą, oddania zmysłowych, ulotnych momentów, wyjątkowego nastroju – \"złapania uciekających chwil\". Bukiet Impresja to lekka kompozycja kwiatowa z róż, margaretek, agapant, eustomy i limonium w delikatnie pastelowej, biało-różowo-fioletowej tonacji kolorystycznej. Poprzez wysyłkę takiego bukietu podarujesz komuś piękne wspomnienie."));
            example.Add(new ProduktModel(297.00, "Bukiet Rubinowy", "kw_rubin.jpg", "Czerwone róże, jak rubiny wśród szlachetnych kamieni, są prawdziwymi arystokratkami kwiatów. Zamów najszlachetniejsze z róż i spraw, by odbiorczyni zakochała się w nich od pierwszego wejrzenia oraz pomyślała gorąco o nadawcy... Bukiet rubinowy dostarczany jest razem z wazonem.Zdjęcie przedstawia róże długości średniej."));
            example.Add(new ProduktModel(137.00, "Kwiaty Dream", "kw_dream.jpg", "Otocz bliską osobę pięknem! Białe margaretki i czerwone goździki to cudne połączenie w bukiecie, który oczaruje każdą kobietę. Chcesz powiedzieć \"przepraszam\", \"kocham\" lub \"dziękuję\" - nie wahaj się i zamów kwiaty piękne jak marzenie."));
            example.Add(new ProduktModel(137.00, "Słodka Niespodzianka", "kw_slodka-niespodzianka.jpg", "Czerwone róże i ekskluzywne czekoladki w eleganckim koszu. Zamów kwiaty proponowane przez naszą firmę i ciesz się pozytywnymi emocjami Twoich najbliższych! Przedstawione na zdjęciu koszyk oraz czekoladki są przykładowe i mogą różnić się wyglądem od tych, które zostaną dostarczone."));
            example.Add(new ProduktModel(159.00, "Bukiet Splendor", "kw_splendor.jpg", "Wyślij najpiękniejsze róże i spraw najlepszą z niespodzianek! Kwiaty online to wspaniały pomysł, jeżeli jesteś daleko, a chciałbyś być bliżej. Herbacianymi różami możesz wyrazić wszystko to, czego nie potrafisz wyrazić słowami. Przekonaj się, że piękny bukiet potrafi zdziałać cuda..."));
            example.Add(new ProduktModel(127.00, "Kwiaty Blask Poranka", "kw_blask.jpg", "Kremowe róże to uczucie wyrażone w delikatny, pełen uroku sposób. Zamawiając te śliczne kwiaty przez Internet skrócisz dzielącą Was odległość i na długo zagościsz w jej myślach... a w sercu już na zawsze!"));
            example.Add(new ProduktModel( 85.00, "Skryta Miłość", "kw_milosc.jpg", "Szukasz delikatnego prezentu, aby podkreślić Twoje uczucia? Chcesz coś subtelnie wyznać? A może oddać hołd urodzie osoby, która Cię zauroczyła? Nasz subtelny bukiet z czerwonych tulipanów będzie do tego idealny. "));
            example.Add(new ProduktModel(107.00, "Ciepłe Pozdrowienia", "kw_pozdrowienia.jpg", "Niektóre uczucia są tak ciepłe, że mogłyby ogrzewać bliską osobę w chłodny wieczór. Okaż, jak gorące jest to, co czujesz. Wyślij bukiet czerwonych tulipanów z winem."));
            example.Add(new ProduktModel(127.00, "Storczyk w doniczce", "kw_storczyk.jpg", "Przedstawiamy storczyk. Dzięki florystom z firmy Poczta Kwiatowa ten wyjątkowy kwiat nabrał jeszcze bardziej egzotycznego charakteru. Podaruj niebanalną kompozycję z ciekawą osłonką, która podkreśli oryginalność i głębię Waszej relacji! Przedstawiona na zdjęciu osłonka jest przykładowa i może różnić się wyglądem od tej, która zostanie doręczona."));
            example.Add(new ProduktModel(197.00, "Kompozycja balkonowa", "kw_balkon.jpg", "Zrób niespodziankę swoim bliskim i prześlij kwiatowe życzenia, wysyłając im balkonową kompozycję. Skróć odległość, jaka was dzieli i poddaj się niezwykłej magii kwiatów, a na pewno sprawisz wielką radość. Nie czekaj, zamów kwiaty przez Internet!"));

            return new OfertaModel(example);
        }


        OfertaModel(List<ProduktModel> produktyWOfercie)
        {
            this.ProduktyWOfercie = produktyWOfercie;
        }
    }
}
