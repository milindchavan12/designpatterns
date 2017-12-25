using DesignPatterns.Command;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class CommandTest
    {
        [Test]
        public void VoiceCommandTest()
        {
            //given
            Radio radio = new Radio();
            radio.SwitchOn();

            IVoiceCommand volumeUpCommand = new VolumeUpCommand(radio);
            IVoiceCommand volumeDownCommand = new VolumeDownCommand(radio);

            ElectricWindow window = new ElectricWindow();
            IVoiceCommand windowUpCommand = new WindowUpCommand(window);
            IVoiceCommand windowDownCommand = new WindowDownCommand(window);

            //when
            SpeachRecogniser speeachRecogniser = new SpeachRecogniser();
            speeachRecogniser.SetCommands(volumeUpCommand, volumeDownCommand);
            System.Console.WriteLine("Speech recognition is controlling radio");
            speeachRecogniser.HearUpSproken();
            speeachRecogniser.HearUpSproken();
            speeachRecogniser.HearUpSproken();
            speeachRecogniser.HearDownSproken();


        }
    }
}
