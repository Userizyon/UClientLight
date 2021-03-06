using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        /// <summary>
        /// Represents a group call participant
        /// </summary>
        public partial class GroupCallParticipant : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "groupCallParticipant";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// Identifier of the group call participant
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("participant")]
public MessageSender Participant { get; set; }

/// <summary>
/// User's synchronization source
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("source")]
public int Source { get; set; }

/// <summary>
/// The participant user's bio or the participant chat's description
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("bio")]
public string Bio { get; set; }

/// <summary>
/// True, if the participant is speaking as set by setGroupCallParticipantIsSpeaking
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_speaking")]
public bool IsSpeaking { get; set; }

/// <summary>
/// True, if the participant hand is raised
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_hand_raised")]
public bool IsHandRaised { get; set; }

/// <summary>
/// True, if the current user can mute the participant for all other group call participants
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("can_be_muted_for_all_users")]
public bool CanBeMutedForAllUsers { get; set; }

/// <summary>
/// True, if the current user can allow the participant to unmute themself or unmute the participant (if the participant is the current user)
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("can_be_unmuted_for_all_users")]
public bool CanBeUnmutedForAllUsers { get; set; }

/// <summary>
/// True, if the current user can mute the participant only for self
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("can_be_muted_for_current_user")]
public bool CanBeMutedForCurrentUser { get; set; }

/// <summary>
/// True, if the current user can unmute the participant for self
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("can_be_unmuted_for_current_user")]
public bool CanBeUnmutedForCurrentUser { get; set; }

/// <summary>
/// True, if the participant is muted for all users
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_muted_for_all_users")]
public bool IsMutedForAllUsers { get; set; }

/// <summary>
/// True, if the participant is muted for the current user
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_muted_for_current_user")]
public bool IsMutedForCurrentUser { get; set; }

/// <summary>
/// True, if the participant is muted for all users, but can unmute themself
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("can_unmute_self")]
public bool CanUnmuteSelf { get; set; }

/// <summary>
/// Participant's volume level; 1-20000 in hundreds of percents
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("volume_level")]
public int VolumeLevel { get; set; }

/// <summary>
/// User's order in the group call participant list. Orders must be compared lexicographically. The bigger is order, the higher is user in the list. If order is empty, the user must be removed from the participant list
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("order")]
public string Order { get; set; }


        }
    }
}
