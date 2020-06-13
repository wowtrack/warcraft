﻿using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests
{
    public class WarcraftClientTestsCharacterProfileApi
    {
        [Fact]
        public async void GetCharacterProfileSummaryAsync_Gets_CharacterProfileSummary()
        {
            IWarcraftClientCharacterProfileApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterProfileSummaryResponse);

            RequestResult<CharacterProfileSummary> result = await warcraftClient.GetCharacterProfileSummaryAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }

        [Fact]
        public async void GetCharacterStatusAsync_Gets_CharacterStatus()
        {
            IWarcraftClientCharacterProfileApi warcraftClient = ClientFactory.BuildMockClient(
                requestUri: "https://us.api.blizzard.com/profile/wow/character/norgannon/drinian/status?namespace=profile-us&locale=en_US",
                responseContent: Resources.CharacterProfileStatusResponse);

            RequestResult<CharacterStatus> result = await warcraftClient.GetCharacterStatusAsync("norgannon", "drinian", "profile-us");
            Assert.NotNull(result.Value);
        }
    }
}