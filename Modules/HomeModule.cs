using Nancy;
using Letter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        var myLetterVariables = new LetterVariables
        {
          Recipient = "Eric",
          Sender = "John"
        };
        return View["hello.html", myLetterVariables];
      };
      Get["/favorite_photos"] = _ => View["favorite_photos.html"];
    }
  }
}
