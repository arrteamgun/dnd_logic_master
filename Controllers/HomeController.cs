using System;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;


public class HomeController : Controller
{   
    public string Index()
    {
        return "default action";
    }

    [HttpPost]
    public IActionResult Result(DiceResult dice)
    {
        var rs = new RollService();
        var result = rs.Result(dice.DiceType, dice.NumberOfDice, dice.Modifier);
        return View(result.ToString()); //?
    }
}