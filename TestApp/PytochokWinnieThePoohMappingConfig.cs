using Mapster;

namespace TestApp;

public class PytochokWinnieThePoohMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Pyatochock228, WinnieThePooh>()
            .Map(winnie => winnie.HoneyCount, pyat => pyat.Zavitushki)
            .Map(winnie => winnie.EarsCount, pyat => Convert.ToInt32(pyat.EarsCount));
    }
}