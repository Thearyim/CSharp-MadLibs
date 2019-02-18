using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/zoo")]
    public ActionResult Zoo(string adjective1, string noun1, string verb1, string adverb1, string adjective2, string noun2, string noun3, string adjective3, string verb2, string adverb2, string verb3, string adjective4) {
      ZooVariable myZooVariable = new ZooVariable();
      myZooVariable.SetNoun1(noun1);
      myZooVariable.SetNoun2(noun2);
      myZooVariable.SetNoun3(noun3);
      myZooVariable.SetAdjective1(adjective1);
      myZooVariable.SetAdjective2(adjective2);
      myZooVariable.SetAdjective3(adjective3);
      myZooVariable.SetAdjective4(adjective4);
      myZooVariable.SetVerb1(verb1);
      myZooVariable.SetVerb2(verb2);
      myZooVariable.SetVerb3(verb3);
      myZooVariable.SetAdverb1(adverb1);
      myZooVariable.SetAdverb2(adverb2);
      return View(myZooVariable);
    }

    [Route("/toy_story")]
   public ActionResult ToyStory(string picture1, string exclamation1, string sound1, string adjective1, string noun1, string month1, string sound2, string adjective2, string noun2, string verb1, string verb2, string drink1, string number1, string color1, string color2, string number2, string noun3, string noun4)
    // public ActionResult ToyStory()
    {
      ToyVariable myToyVariable = new ToyVariable();
      myToyVariable.SetPicture1(picture1);
      myToyVariable.SetExclamation1(exclamation1);
      myToyVariable.SetSound1(sound1);
      myToyVariable.SetAdjective1(adjective1);
      myToyVariable.SetNoun1(noun1);
      myToyVariable.SetMonth1(month1);
      myToyVariable.SetSound2(sound2);
      myToyVariable.SetAdjective2(adjective2);
      myToyVariable.SetNoun2(noun2);
      myToyVariable.SetVerb1(verb1);
      myToyVariable.SetVerb2(verb2);
      myToyVariable.SetDrink1(drink1);
      myToyVariable.SetNumber1(number1);
      myToyVariable.SetColor1(color1);
      myToyVariable.SetColor2(color2);
      myToyVariable.SetNumber2(number2);
      myToyVariable.SetNoun3(noun3);
      myToyVariable.SetNoun4(noun4);
      return View(myToyVariable);
    }
    // [Route("/toy_story")]
    // public ActionResult ToyStory() { return View(); }

    [Route("/zoo_form")]
    public ActionResult ZooForm() { return View(); }

    [Route("/toy_form")]
    public ActionResult ToyForm() { return View(); }

    [Route("/")]
    public ActionResult Form() { return View(); }
  }
}
