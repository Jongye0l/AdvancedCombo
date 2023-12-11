namespace AdvancedCombo {
    public class Values {
        public static readonly Values Korean = new Values {
            Setting_AutoTileCombo = "자동플레이 타일로 인한 판정도 콤보에 포함시키기",
            Setting_FirstOnly = "초록, 노란색 콤보가 한번 끊기면 자동 콤보를 무조건 빨간색 콤보로 뜨게 하기",
            Setting_GreenCombo = "자동 콤보가 초록색 콤보일 경우 나올 텍스트",
            Setting_YellowCombo = "자동 콤보가 노란색 콤보일 경우 나올 텍스트",
            Setting_RedCombo = "자동 콤보가 빨간색 콤보일 경우 나올 텍스트",

            Credit_Devloper = "개발자",
            Credit_Source = "소스 코드",
            Credit_BugReport = "이 모듈에 대한 버그는 깃허브나 디스코드 'jongyeol_'에게 연락주세요."
        };

        public static readonly Values English = new Values {
            Setting_AutoTileCombo = "Include Autoplay tile judgments in combo as well",
            Setting_FirstOnly = "Once the green and yellow combo is disconnected, make the automatic combo pop up with the red combo",
            Setting_GreenCombo = "Text that will come out if the auto combo is a green combo",
            Setting_YellowCombo = "Text that will come out if the auto combo is a yellow combo",
            Setting_RedCombo = "Text that will come out if the auto combo is a red combo",

            Credit_Devloper = "Developer",
            Credit_Source = "Source Code",
            Credit_BugReport = "Please contact GitHub or Discord 'jongyeol_' for bugs about this module."
        };
        
        public string Setting_AutoTileCombo;
        public string Setting_FirstOnly;
        public string Setting_GreenCombo;
        public string Setting_YellowCombo;
        public string Setting_RedCombo;

        public string Credit_Devloper;
        public string Credit_Source;
        public string Credit_BugReport;
    }
}