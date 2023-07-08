using System.Threading;

namespace Delay
{
   public static class CDelay
   {
      public static void Delay(uint uintNumSeconds)
      {
         Thread.Sleep((int)(uintNumSeconds * 1000)); // delay
      }
   }
}
