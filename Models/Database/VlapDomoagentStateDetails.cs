﻿using System;
using System.Collections.Generic;

namespace ProgrammaticFiltering.Models.Database
{
    public partial class VlapDomoagentStateDetails
    {
        public string Agent { get; set; }
        public string AgentFirstName { get; set; }
        public string AgentLastName { get; set; }
        public long? Time { get; set; }
        public string State { get; set; }
        public string ReasonCode { get; set; }
        public string MediaAvailability { get; set; }
        public string SkillAvailability { get; set; }
        public long? AgentStateTime { get; set; }
        public string AgentEmail { get; set; }
        public string AgentGroup { get; set; }
        public string AgentId { get; set; }
        public string AgentName { get; set; }
        public DateTime? AgentStartDate { get; set; }
        public string AgentStartMonth { get; set; }
        public int? AgentStartYear { get; set; }
        public string EnabledForVideo { get; set; }
        public int? Extension { get; set; }
        public DateTime? Date { get; set; }
        public string DateAndHour { get; set; }
        public double? DayOfMonth { get; set; }
        public string DayOfWeek { get; set; }
        public string EndTimeMillisecond { get; set; }
        public string HalfHour { get; set; }
        public string Hour { get; set; }
        public int? HourOfDay { get; set; }
        public string Month { get; set; }
        public string QuarterHour { get; set; }
        public string TimeInterval { get; set; }
        public DateTime? Timestamp { get; set; }
        public string TimestampMillisecond { get; set; }
        public int? Year { get; set; }
        public double? AgentStates { get; set; }
        public string AvailableForAll { get; set; }
        public string AvailableForCalls { get; set; }
        public string AvailableForVm { get; set; }
        public string UnavailableForCalls { get; set; }
        public string UnavailableForVm { get; set; }
        public long? LoginTime { get; set; }
        public string LoginTimestamp { get; set; }
        public long? LogoutTime { get; set; }
        public string LogoutTimestamp { get; set; }
        public long? ManualTime { get; set; }
        public long? NotReadyTime { get; set; }
        public long? OnAcwTime { get; set; }
        public long? OnCallTime { get; set; }
        public long? OnVoicemailTime { get; set; }
        public long? PaidTime { get; set; }
        public long? ReadyTime { get; set; }
        public long? RingingTime { get; set; }
        public long? UnpaidTime { get; set; }
        public string VideoTime { get; set; }
        public long? VmInProgressTime { get; set; }
        public long? WaitTime { get; set; }
        public bool? AgentDisconnectsFirst { get; set; }
        public string Ani { get; set; }
        public double? CallId { get; set; }
        public string CallSurveyResult { get; set; }
        public string CallType { get; set; }
        public double? Calls { get; set; }
        public string CallsUnansweredByAgent { get; set; }
        public string Campaign { get; set; }
        public string CampaignType { get; set; }
        public string ConsultsAnswered { get; set; }
        public string ConsultsInitiated { get; set; }
        public string DisconnectedFromHold { get; set; }
        public string Disposition { get; set; }
        public string DispositionGroupA { get; set; }
        public string DispositionGroupB { get; set; }
        public string DispositionGroupC { get; set; }
        public string DispositionPath { get; set; }
        public string Dnis { get; set; }
        public string Skill { get; set; }
        public string TransferredToAgent { get; set; }
        public string TransferredToCampaign { get; set; }
        public string TransferredToSkill { get; set; }
        public string TransfersToSameQueue { get; set; }
        public long? AfterCallWorkTime { get; set; }
        public long? ConferenceTime { get; set; }
        public double? Conferences { get; set; }
        public long? ConsultTime { get; set; }
        public double? Consults { get; set; }
        public long? DialTime { get; set; }
        public long? HandleTime { get; set; }
        public long? HoldTime { get; set; }
        public double? Holds { get; set; }
        public string LongAfterCallWork { get; set; }
        public string LongCalls { get; set; }
        public string LongHolds { get; set; }
        public string LongParks { get; set; }
        public string MissedCalls { get; set; }
        public string MissedCallsReturned { get; set; }
        public long? ParkTime { get; set; }
        public double? Parks { get; set; }
        public double? PreviewInterrupted { get; set; }
        public double? PreviewInterruptedByCall { get; set; }
        public string PreviewInterruptedBySkillVm { get; set; }
        public long? PreviewTime { get; set; }
        public string QueueCallbackProcessing { get; set; }
        public string QueueCallbackRegistered { get; set; }
        public long? RingTime { get; set; }
        public string ShortAfterCallWork { get; set; }
        public string ShortCalls { get; set; }
        public long? TalkTime { get; set; }
        public long? TalkTimeLessHoldAndPark { get; set; }
        public string TimeToReturnMissedCall { get; set; }
        public string Transfers { get; set; }
        public string Worksheet { get; set; }
        public string VoicemailHandleTime { get; set; }
        public double? Voicemails { get; set; }
        public string VoicemailsDeclined { get; set; }
        public string VoicemailsDeleted { get; set; }
        public string VoicemailsHandled { get; set; }
        public string VoicemailsReturnedCall { get; set; }
        public string VoicemailsTransferred { get; set; }
    }
}
