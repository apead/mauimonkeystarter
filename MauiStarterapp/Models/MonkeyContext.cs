using System.Text.Json.Serialization;

namespace MauiStarterapp.Models
{
    [JsonSerializable(typeof(List<Monkey>))]
    internal sealed partial class MonkeyContext : JsonSerializerContext
    {

    }
}
