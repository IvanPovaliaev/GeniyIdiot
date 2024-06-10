namespace GeniyIdiot.Common
{
    public static class DiagnosisManager
    {
        public static string GetDiagnosis(int countRigthAnswers, int countQuestions)
        {
            var rightAnswersPercent = 100 * countRigthAnswers / countQuestions;
            if (rightAnswersPercent < 10) return "Идиот";
            if (rightAnswersPercent < 30) return "Кретин";
            if (rightAnswersPercent < 50) return "Дурак";
            if (rightAnswersPercent < 70) return "Нормальный";
            if (rightAnswersPercent < 90) return "Талант";
            return "Гений";
        }
    }
}