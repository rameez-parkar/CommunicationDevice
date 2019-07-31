using CommunicationDevice.App;
using System;
using Xunit;

namespace CommunicationDevice.Test
{
    public class CommunicationDeviceTest
    {
        [Fact]
        public void SmartphoneMakeCallsTest()
        {
            var smartphone = new Smartphone();
            var call = new Call(smartphone);
            var device = new Device(call);

            var phoneNumber = "8380910769";
            var action = call.MakeCall(phoneNumber);

            var expected = "Calling 8380910769 ...";
            var actual = device.PerformAction(action);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TelephoneMakeCallsTest()
        {
            var telephone = new Telephone();
            var call = new Call(telephone);
            var device = new Device(call);

            var phoneNumber = "8380910769";
            var action = call.MakeCall(phoneNumber);

            var expected = "Calling 8380910769 ...";
            var actual = device.PerformAction(action);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MobileMakeCallsTest()
        {
            var mobile = new Mobile();
            var call = new Call(mobile);
            var device = new Device(call);

            var phoneNumber = "8380910769";
            var action = call.MakeCall(phoneNumber);

            var expected = "Calling 8380910769 ...";
            var actual = device.PerformAction(action);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SmartphoneTextMessageTest()
        {
            var smartphone = new Smartphone();
            var text = new TextMessage(smartphone);
            var device = new Device(text);

            var phoneNumber = "8380910769";
            var message = "Hello World!";
            var action = text.SendTextMessage(message, phoneNumber);

            var expected = "Sending \"Hello World!\" to 8380910769 ...";
            var actual = device.PerformAction(action);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MobileTextMessageTest()
        {
            var mobile = new Mobile();
            var text = new TextMessage(mobile);
            var device = new Device(text);

            var phoneNumber = "8380910769";
            var message = "Hello World!";
            var action = text.SendTextMessage(message, phoneNumber);

            var expected = "Sending \"Hello World!\" to 8380910769 ...";
            var actual = device.PerformAction(action);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SmartphonePlayMusicTest()
        {
            var smartphone = new Smartphone();
            var feature = new AdditionalFeatures(smartphone);
            var device = new Device(feature);

            var songTitle = "In The End.mp3";
            var action = feature.PlayMusic(songTitle);

            var expected = "Playing In The End.mp3 ...";
            var actual = device.PerformAction(action);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SmartphoneAccessInternetTest()
        {
            var smartphone = new Smartphone();
            var feature = new AdditionalFeatures(smartphone);
            var device = new Device(feature);

            var url = "www.google.com";
            var action = feature.AccessInternet(url);

            var expected = "Connecting to \"www.google.com\" ...";
            var actual = device.PerformAction(action);

            Assert.Equal(expected, actual);
        }
    }
}
