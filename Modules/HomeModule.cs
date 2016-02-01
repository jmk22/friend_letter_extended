using Nancy;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["hello.html"];
    }
  }
}
