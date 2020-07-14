﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<CharacterPvpBracketStatistics>> GetCharacterPvpBracketStatisticsAsync(string realmSlug, string characterName, string pvpBracket, string @namespace)
        {
            return await GetCharacterPvpBracketStatisticsAsync(realmSlug, characterName, pvpBracket, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterPvpBracketStatistics>> GetCharacterPvpBracketStatisticsAsync(string realmSlug, string characterName, string pvpBracket, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CharacterPvpBracketStatistics>(region, $"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/pvp-bracket/{pvpBracket}?namespace={@namespace}&locale={locale}");
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterPvpSummary>> GetCharacterPvpSummaryAsync(string realmSlug, string characterName, string @namespace)
        {
            return await GetCharacterPvpSummaryAsync(realmSlug, characterName, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterPvpSummary>> GetCharacterPvpSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CharacterPvpSummary>(region, $"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/pvp-summary?namespace={@namespace}&locale={locale}");
        }
    }
}