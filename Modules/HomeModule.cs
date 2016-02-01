using Nancy;
using Letter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/greeting_card"] = _ => {
        var myLetterVariables = new LetterVariables
        {
          Sender = Request.Query["sender"],
          Recipient = Request.Query["recipient"]
        };
        return View["hello.html", myLetterVariables];
      };
      Get["/favorite_photos"] = _ => View["favorite_photos.html"];
      Get["/form"] = _ => View["form.html"];
    }
  }
}
