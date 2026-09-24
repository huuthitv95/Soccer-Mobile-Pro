namespace SL
{
    internal class ABTest
    {
        public struct ABTestItem
        {
            public string keyname;
            public string defaultvalues;
            public ABTestItem(string k, string v)
            {
                keyname = null;
                defaultvalues = null;
            }
        }

        public enum CONFIG_NAME
        {
            all_ads_on = 0,
            ExtraLog = 1,
            EarnDailyTrigger = 2,
            EarnTroas = 3,
            EarnMultiple = 4,
            AdjustRealTimeLog = 5,
            RewardedPlan = 6,
            InterstitialPlan = 7,
            InterstitialPlanTidy = 8,
            BannerPlan = 9,
            match_length = 10,
            rating_switch = 11,
            first_rating_condition = 12,
            rating_condition = 13,
            rating_interval = 14,
            reset_rating_version = 15,
            reward_video = 16,
            AdltvOneDay = 17,
            AdjustEarnMultiple = 18,
            AdmobEarnSendToAdjust = 19,
            UserArriveProgressValue = 20,
            UserIntersectionCondition = 21,
            AdjustADRevenue = 22,
            UserFirstCompleteEvent = 23,
            send_revenue_tokens = 24,
            AppOpenPlan = 25,
            AppOpenSwitch = 26,
            reward_video_2 = 27,
            ad_borad_type = 28,
            reward_video_3 = 29,
            reward_video_4 = 30,
            PromoteMailBoxLevel = 31,
            PromoteInterstitialFillRate = 32,
            PromoteAppopenFillRate = 33,
            fatigue_to_injury_rate = 34,
            reward_video_5 = 35,
            use_match_snapshot = 36,
            AdUnitVersion = 37,
            match_config_index = 38,
            AskIDFAiOSVersion = 39,
            ad_plan = 40,
            FBEarnMultiple = 41,
            FBEarnValue = 42,
            StaminaConfig = 43,
            camera_config = 44,
            playerDevelopment = 45,
            ad_min_interval = 46,
            in_match_interstitial = 47,
            InputTestConfig = 48,
            in_match_banner_pos = 49,
            EarnSendToFacebook = 50,
            match_highlight = 51,
            enable_banner_log = 52,
            AIVersion = 53,
            audit = 54,
            ios_game_mode = 55,
            training = 56,
            enable_interstitial = 57,
            gameplay_assist_by_property = 58,
            custom_league = 59,
            appearance_plan = 60,
            player_name_arb = 61,
            show_radar = 62,
            enable_inpiece_special = 63,
            touch_input_type = 64,
            freekick_input_type = 65,
            match_record = 66,
            admob_ump_config_new = 67,
            admob_ump_repeat_on_deny_new = 68,
            is_request_on = 69,
            adid_request_URL = 70,
            enable_match_training = 71,
            classic_team_match_challenge = 72,
            enable_sliding_advantage = 73,
            additional_ad_slots = 74,
            appopen_interval = 75,
            new_dynamic_difficulty_rule = 76,
            competition_challenge = 77,
            coin_output_plan = 78,
            coin_video_plan = 79,
            SlideInputParameter = 80,
            enable_player_contract = 81,
            dynamic_crowd = 82,
            enable_appearance_shop = 83,
            long_match_ad_interval_reduction = 84,
            social_media_promotion = 85,
            defense_input_plan = 86,
            enable_audio_ad = 87,
            audio_ad_min_interval = 88,
            enable_admob_adBorad = 89,
            enable_new_animations = 90,
            audio_ad_plan = 91,
            commentator_plan = 92,
            audio_placement_normal = 93,
            audio_placement_setpiece = 94,
            admob_abtest_rewarded = 95,
            enable_remove_ad = 96,
            no_ads_before_match_count = 97,
            admob_abtest_interstitial = 98,
            admob_abtest_banner = 99,
            adjust_earned_multiple_2 = 100,
            tactics_version = 101,
            admob_multiple_rv = 102,
            check_rv_interval = 103,
            iv_cache_plan = 104,
            custom_team_match_challenge = 105,
            memory_key_value_switch = 106,
            main_view_btn_access_plan = 107,
            rv_gold_buttons = 108,
            difficulty_popup = 109,
            ai_low_speed = 110,
            need_confirm_rv = 111,
            iv_replace_rv_all = 112,
            banner_mode = 113,
            mirrored_match_challenge = 114,
            new_field = 115,
            new_ball_physics = 116,
            inmatch_freekick_offset = 117,
            enable_playing_style = 118,
            enable_playback_rate = 119,
            ai_protection_pass = 120,
            ai_protection_dribble = 121,
            in_match_interstitial_minigame = 122,
            interstitial_plan_tidy_load = 123,
            enable_new_support = 124,
            remote_player_shoots = 125,
            defense_version = 126,
            shoot_version = 127,
            era_finale_challenge = 128,
            last_dance_challenge = 129,
            enable_tactical_style = 130,
            defense_movement_version = 131,
            new_interfere_direction = 132,
            shielding_version = 133,
            enable_ad_banner = 134,
            ai_shot_power_version = 135,
            player_control_assist_version = 136,
            balcontrol_auto_protect_ball = 137,
            dynamic_press_positivity = 138,
            pass_more_cautiously = 139,
            referee_checkfoul_version = 140,
            ballcontrol_version = 141,
            ai_teammate_press_version = 142,
            man_city_resource_pack = 143,
            monaco_resource_pack = 144,
            switch_press_to_sprint = 145,
            auto_switch_player_level = 146,
            blocked_iv_position = 147,
            moment_challenge_version = 148,
            manual_through_half_autopass = 149,
            support_version = 150,
            transposition_version = 151,
            pass_target_version = 152,
            switch_controlled_version = 153,
            screen_time_tracker_enable = 154,
            shoot_direction_version = 155,
            remote_match_info_2 = 156,
            remote_player_pass = 157,
            manual_low_pass_threshold = 158,
            through_pass_version = 159,
            enable_iap_store = 160,
            through_target_version = 161,
            limited_time_pack = 162,
            native_ads_units = 163,
            native_countdown = 164,
            native_ads_plan = 165,
            game_promotion = 166,
            game_promotion_coin = 167,
            enable_game_promotion_popup = 168,
            native_ads_auto_close = 169,
            classic_team_match_challenge2 = 170,
            tour_event = 171,
            debey_challenge_event = 172,
            wc_redeem_code = 173,
            difficulty_curve_version = 174,
            custom_adboard_groups = 175,
            custom_adboard_strategy = 176,
            non_store_install_key_value = 177,
            ad_preloading_admob = 178,
            ad_preloading_memory = 179,
            remove_ads_promotion = 180,
            enable_promotion_popup = 181,
            ad_btn_style = 182,
            cpu_dribble_version = 183,
            difficulty_selection = 184,
            event_log_blacklist = 185,
            enable_player_career = 186,
            player_career_camera_version = 187,
            transfer_bargain = 188,
            enable_local_pvp = 189,
            max_revenue_threshold = 190,
            max_ads = 191,
            set_pieces_version = 192,
            enable_player_career_rv_optimization = 193,
            dynamic_parallel_camera_default = 194,
            sponsor_ad_plan = 195,
            questionnaire_config = 196,
            corner_switch_version = 197,
            Count = 198
        }

        public enum AdBoradType
        {
            None = 0,
            Gadsme = 1,
            Count = 2
        }

        public struct CustomAdBoardStrategyParams
        {
            public int mode;
            public int baseCooldown;
            public int maxCooldown;
            public float aggressiveness;
        }

        public static class IVReplaceRV
        {
            public static bool open;
            public static bool transfer_refresh_ml;
            public static global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>> IVReplaceRV_all;
        }

        internal static class VersionUpgradeABSwitchHandler
        {
            private static readonly string versionUpgradeFlagKey;
            internal static void MarkVersionUpgrade()
            {
            }

            internal static void CheckAndHandleVersionUpgrade()
            {
            }
        }

        public static readonly global::SL.ABTest.ABTestItem[] abItems;
        public static bool IsReady;
        public const bool EnableFirebase = true;
        private static global::SL.IABTestImpl abTestImpl;
        private static global::System.Collections.Generic.List<int> _earnDailyTrigger;
        private static string _earnDailyEventname;
        private static global::System.Collections.Generic.HashSet<string> eventLogBlacklist;
        private static float lastRefreshEventLogBlacklistTime;
        private static global::System.Collections.Generic.Dictionary<string, global::System.DateTime> limitedTimePack;
        private static float lastRefreshLimitedTimePackTime;
        private static global::System.Collections.Generic.HashSet<string> blockedIV;
        private static global::System.Collections.Generic.List<string> blockedIV_prefixPattern;
        private static float lastBlockedIVUpdateTime;
        private static int bannerMode;
        private static bool initBannerMode;
        private static global::System.Collections.Generic.Dictionary<string, string> admobTag;
        private static global::System.DateTime lastAdmobTagParseTime;
        private static global::System.Collections.Generic.Dictionary<string, string> admobInterstitialTag;
        private static global::System.DateTime lastAdmobInterstitialTagParseTime;
        private static global::System.Collections.Generic.Dictionary<string, string> admobMultipleRVTag;
        private static global::System.DateTime lastAdmobMultipleRVParseTime;
        private static global::System.Collections.Generic.Dictionary<string, string> admobBannerTag;
        private static global::System.DateTime lastAdmobBannerTagParseTime;
        private static global::System.Collections.Generic.Dictionary<string, string> nonStoreInstallKeyValue;
        private static global::System.DateTime lastNonStoreInstallKeyValueParseTime;
        public static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> UserIntersectionEvent;
        public static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>> intersectionCondition;
        public static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<string>>> FirstCompleteEventInputDict;
        public static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>> FirstCompleteEventAdjustTrackerDict;
        private static global::System.Collections.Generic.Dictionary<string, string> _sendRevenueTokens;
        private static global::System.DateTime lastParseTime;
        private static int _uploadReplayCount;
        private static float _uploadFrameRate;
        private static int upmSwitch;
        private static int upmBannerPlan;
        private static int upmInterstitialPlan;
        private static int upmRewardedPlan;
        private static float[] _fatigueRate;
        private static global::System.Collections.Generic.List<int> _troasTrigger;
        private static bool? _extralog;
        private static global::System.Collections.Generic.List<global::SL.ABTest.CONFIG_NAME> NeedStaticConfig;
        private static global::System.Collections.Generic.List<global::SL.ABTest.CONFIG_NAME> Reset2DefaultOnUpgrade;
        public static int TransferBargain => 0;
        public static bool EnableLocalPVP => false;
        public static bool EarnSendToFacebook => false;
        public static bool AllAdsOn => false;
        public static int AdMinInterval => 0;
        public static int InMatchInterstitial => 0;
        public static AdsManager.BannerPosition InMatchBannerPosition => AdsManager.BannerPosition.Top;
        public static int MatchHighlight => 0;
        public static bool EnableBannerLog => false;
        public static int InputTestConfig => 0;
        public static int AIVersion => 0;
        public static bool AdjustRealTimeLog => false;
        public static int RewardedPlan => 0;
        public static int BannerPlan => 0;
        public static int InterstitialPlan => 0;
        public static int InterstitialPlanTidy => 0;
        public static int MaxRevenueThreshold => 0;
        public static bool MaxAds => false;
        public static int SetPiecesVersion => 0;
        public static global::System.Collections.Generic.List<int> EarnDailyTrigger => null;
        public static int MatchLenght => 0;
        public static bool RatingSwitch => false;
        public static int FirstRatingCondition => 0;
        public static int RatingCondition => 0;
        public static float RatingInterval => 0f;
        public static string ResetRatingVersion => null;
        public static int RewardVideo => 0;
        public static int IosGameMode => 0;
        public static bool UseTraining => false;
        public static int Training => 0;
        public static bool EnableInterstitial => false;
        public static int AskIDFAiOSVersion => 0;
        public static int ad_plan => 0;
        public static bool gameplay_assist_by_property => false;
        public static bool CustomLeague => false;
        public static int AppearancePlan => 0;
        public static int PlayerNameArb => 0;
        public static bool showRadar => false;
        public static bool enable_inpiece_special => false;
        public static int TouchInputType => 0;
        public static int touchInputPlan => 0;
        public static int FreeKickInputType => 0;
        public static bool IsRequestOn => false;
        public static string AdidRequestURL => null;
        public static string WcRedeemCode => null;
        public static bool EnableTacticalStyle => false;
        public static int DefenseMovementVersion => 0;
        public static bool NewInterfereDirection => false;
        public static int ShieldingVersion => 0;
        public static bool EnableAdBanner => false;
        public static int AiShotPowerVersion => 0;
        public static int PlayerControlAssistVersion => 0;
        public static bool balcontrol_auto_protect_ball => false;
        public static int dynamic_press_positivity => 0;
        public static bool pass_more_cautiously => false;
        public static int referee_checkfoul_version => 0;
        public static int ai_teammate_press_version => 0;
        public static string ManCityResourcePackConfig => null;
        public static bool switch_press_to_sprint => false;
        public static int auto_switch_player_level => 0;
        public static bool enable_moment_challenge => false;
        public static int moment_challenge_version => 0;
        public static bool manual_through_half_autopass => false;
        public static int support_version => 0;
        public static int transposition_version => 0;
        public static int pass_target_version => 0;
        public static int switch_controlled_version => 0;
        public static int corner_switch_version => 0;
        public static bool screen_time_tracker_enable => false;
        public static int shoot_direction_version => 0;
        public static bool remote_match_info_2 => false;
        public static bool remote_player_pass => false;
        public static int manual_low_pass_threshold => 0;
        public static int through_pass_version => 0;
        public static bool enable_iap_store => false;
        public static bool enable_promotion_popup => false;
        public static int through_target_version => 0;
        public static int native_ads_units => 0;
        public static int native_countdown => 0;
        public static int native_ads_plan => 0;
        public static bool EnableGamePromotion => false;
        public static bool GamePromotionCoin => false;
        public static bool EnableGamePromotionPopup => false;
        public static bool native_ads_auto_close => false;
        public static int difficulty_curve_version => 0;
        public static int ADBtnStyle => 0;
        public static int CpuDribbleVersion => 0;
        public static bool EnableDifficultySelection => false;
        public static bool EnablePlayerCareer => false;
        public static bool EnablePlayerCareerRVOptimization => false;
        public static int PlayerCareerCameraVersion => 0;
        public static bool UseDynamicParallelCameraByDefault => false;
        public static string SponsorAdConfig => null;
        public static string QuestionnaireConfig => null;
        public static bool UseNewField => false;
        public static bool NewBallPhysics => false;
        public static bool InMatchFreeKickOffset => false;
        public static bool EnablePlayingStyle => false;
        public static bool EnablePlaybackRate => false;
        public static bool AiProtectionPass => false;
        public static bool AiProtectionDribble => false;
        public static bool InMatchInterstitialMinigame => false;
        public static bool InterstitialPlanTidyLoad => false;
        public static bool EnableNewSupport => false;
        public static bool RemotePlayerShoots => false;
        public static int ShootVersion => 0;
        public static bool MemoryKeyValueSwitch => false;
        public static int MainViewBtnAccessPlan => 0;
        public static bool MoreCoinRV => false;
        public static int DifficultyPopup => 0;
        public static bool AILowSpeed => false;
        public static bool NeedConfirmRV => false;
        public static int CoinOutputPlan => 0;
        public static int CoinVideoPlan => 0;
        public static string SlideInputParameter => null;
        public static bool EnablePlayerContract => false;
        public static bool dynamicCrowd => false;
        public static bool enableAppearanceShop => false;
        public static int LongMatchAdIntervalReduction => 0;
        public static int SocialMediaPromotion => 0;
        public static int DefenseInputPlan => 0;
        public static bool EnableAudioAd => false;
        public static (int, int) AudioAdMinInterval => default;
        public static bool EnableAdmobAdBorad => false;
        public static int AudioAdPlan => 0;
        public static int CommentatorPlan => 0;
        public static string AudioPlacementNormal => null;
        public static string AudioPlacementSetpiece => null;
        public static global::System.Collections.Generic.Dictionary<string, string> AdmobTag => null;
        public static global::System.Collections.Generic.Dictionary<string, string> AdmobInterstitialTag => null;
        public static float AdjustEarnMultiple2 => 0f;
        public static int TacticsVersion => 0;
        public static global::System.Collections.Generic.Dictionary<string, string> AdmobMultipleRVTag => null;
        public static int CheckRVInterval => 0;
        public static int IVCachePlan => 0;
        public static global::System.Collections.Generic.Dictionary<string, string> AdmobBannerTag => null;
        public static global::System.Collections.Generic.Dictionary<string, string> NonStoreInstallKeyValue => null;
        public static bool AdPreloadingAdmobEnable => false;
        public static int AdPreloadingAdmobSize => 0;
        public static int AdPreloadingMemory => 0;
        public static bool EnableRemoveAd => false;
        public static bool IsRemoveAdsPromotionActive => false;
        public static bool CanShowAds => false;
        public static bool EnableMatchTraining => false;
        public static bool EnableSlidingAdvantage => false;
        public static int AdditionalAdSlots => 0;
        public static int AppOpenInterval => 0;
        public static int NewDynamicDifficultyRule => 0;
        public static global::System.Collections.Generic.Dictionary<int, string> AdltvOneDay => null;
        public static float AdjustEarnMultiple => 0f;
        public static bool AdmobEarnSendToAdjust => false;
        public static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<int, string>> UserArriveProgressValue => null;
        public static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>> UserIntersectionCondition => null;
        public static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, int>> UserFirstCompleteEvent => null;
        public static global::System.Collections.Generic.Dictionary<string, string> SendRevenueTokens => null;
        public static int AppOpenPlan => 0;
        public static bool AppOpenSwitch => false;
        public static float FBEarnMultiple => 0f;
        public static float FBEarnValue => 0f;
        public static int StaminaConfig => 0;
        public static int CameraConfig => 0;
        public static bool PlayerDevelopment => false;
        public static int RewardVideo2 => 0;
        public static global::SL.ABTest.AdBoradType GetADBoradType => global::SL.ABTest.AdBoradType.None;
        public static global::System.Collections.Generic.List<int> GetCustomAdBoardGroups => null;
        public static global::SL.ABTest.CustomAdBoardStrategyParams GetCustomAdBoardStrategy => default;
        public static int RewardVideo3 => 0;
        public static int RewardVideo5 => 0;
        public static bool UseMatchSnapshot => false;
        public static bool AdjustADRevenue => false;
        public static int MatchConfigIndex => 0;
        public static int UploadReplaycount => 0;
        public static float UploadReplayFramerate => 0f;
        public static int AdmobUmpSwitch => 0;
        public static int AdmobUmpBannerPlan => 0;
        public static int AdmobUmpInterstitialPlan => 0;
        public static int AdmobUmpRewardedPlan => 0;
        public static bool AdmobUmpRepeatOnDeny => false;
        public static string EarnDailyEventName => null;
        public static int PromoteMailBoxLevel => 0;
        public static float PromoteAppopenFillRate => 0f;
        public static float PromoteInterstitialFillRate => 0f;
        public static float[] FatigueToInjuryRate => null;
        public static global::System.Collections.Generic.List<int> EarnTroasTrigger => null;
        public static float EarnMultiple => 0f;
        public static bool ExtraLog => false;
        public static bool IOSAudit => false;

        public static void Init()
        {
        }

        public static T SerializeStringValueFromPrefs<T>(global::SL.ABTest.CONFIG_NAME eventName)
        {
            return default;
        }

        public static void SaveTouchInputType(int value)
        {
        }

        public static void GetClassicTeamMatchChallengeCfg(out global::System.DateTime start, out global::System.DateTime end, out int configId)
        {
            start = default;
            end = default;
            configId = default;
        }

        public static void GetCustomTeamMatchChallengeCfg(out global::System.DateTime start, out global::System.DateTime end, out int configId)
        {
            start = default;
            end = default;
            configId = default;
        }

        public static void GetMirroredMatchChallengeCfg(out global::System.DateTime start, out global::System.DateTime end, out int configId)
        {
            start = default;
            end = default;
            configId = default;
        }

        public static void GetEraFinaleChallengeCfg(out global::System.DateTime start, out global::System.DateTime end, out int configId)
        {
            start = default;
            end = default;
            configId = default;
        }

        public static void GetLastDanceChallengeCfg(out global::System.DateTime start, out global::System.DateTime end, out int configId)
        {
            start = default;
            end = default;
            configId = default;
        }

        public static void GetClassicTeamMatchChallenge2Cfg(out global::System.DateTime start, out global::System.DateTime end, out int configId)
        {
            start = default;
            end = default;
            configId = default;
        }

        public static void GetTourEventCfg(out global::System.DateTime start, out global::System.DateTime end, out string configFileName)
        {
            start = default;
            end = default;
            configFileName = null;
        }

        public static void GetDebeyChallengeEventCfg(out global::System.DateTime start, out global::System.DateTime end, out string configFileName)
        {
            start = default;
            end = default;
            configFileName = null;
        }

        public static bool IsEventLogInBlacklist(string eventName)
        {
            return false;
        }

        public static bool IsLimitedTimePackAvailable(string gameplayID, out global::System.DateTime expireTime)
        {
            expireTime = default;
            return false;
        }

        public static bool IVIsBlocked(string pos)
        {
            return false;
        }

        public static int GetBannerMode()
        {
            return 0;
        }

        public static void GetCompetitionChallengeCfg(out global::System.DateTime start, out global::System.DateTime end, out int configId)
        {
            start = default;
            end = default;
            configId = default;
        }

        private static void PraseChallengeConfig(global::SL.ABTest.CONFIG_NAME challengeType, out global::System.DateTime start, out global::System.DateTime end, out int configId)
        {
            start = default;
            end = default;
            configId = default;
        }

        private static void PraseChallengeFileConfig(global::SL.ABTest.CONFIG_NAME challengeType, out global::System.DateTime start, out global::System.DateTime end, out string configFileName)
        {
            start = default;
            end = default;
            configFileName = null;
        }

        private static void PraseAdmobTag(ref string v, global::System.Collections.Generic.Dictionary<string, string> tag)
        {
        }

        public static void ParseNewUserLimitEventValue()
        {
        }

        internal static void ParseMatchRecord()
        {
        }

        private static void ParseUPMConfig()
        {
        }

        internal static void ParseOnNewValue()
        {
        }

        public static void ParseIVReplaceRV()
        {
        }

        private static void ParseEarnDailyTrigger()
        {
        }

        public static void UploadRemoteAdUnit(int adUnit, string adUnitHashCode)
        {
        }

        internal static void ParseAdUnitParam()
        {
        }

        private static void ParseTroasTrigger()
        {
        }

        public static void SetRemoteValue(string key, string value)
        {
        }

        internal static void Refresh2DefaultConfig()
        {
        }

        internal static bool Refresh2RemoteConfig()
        {
            return false;
        }

        internal static void ClearNotSupportABConfig()
        {
        }

        public static void UsingDefaults(bool force = false)
        {
        }

        private static void RefreshStandaloneConfig(global::System.Collections.Generic.HashSet<string> remoteKeys)
        {
        }

        public static string ReadFromPrefs(global::SL.ABTest.CONFIG_NAME e)
        {
            return null;
        }

        public static int ReadIntFromPrefs(global::SL.ABTest.CONFIG_NAME e)
        {
            return 0;
        }

        public static float ReadFloatFromPrefs(global::SL.ABTest.CONFIG_NAME e)
        {
            return 0f;
        }

        public static bool ReadBoolFromPrefs(global::SL.ABTest.CONFIG_NAME e)
        {
            return false;
        }

        public static global::System.Collections.Generic.Dictionary<string, object> GetDefaultValues()
        {
            return null;
        }
    }
}