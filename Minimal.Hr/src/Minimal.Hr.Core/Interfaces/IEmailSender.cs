using System.Threading.Tasks;

namespace Minimal.Hr.Core.Interfaces;

public interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}
