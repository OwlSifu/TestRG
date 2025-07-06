using UnityEngine;

namespace Game.Scriptables
{
    [CreateAssetMenu(menuName = "Game/CubeNumberGenerator")]
    class CubeNumberGenerator : ScriptableObject
    {
        [Header("Initial Spawn Settings")]
        [SerializeField] private int _chanceToSpawnMinValue = 75;
        [SerializeField] private int _minValue = 2;
        [SerializeField] private int _maxValue = 4;

        public int Generate()
        {
            return Random.value < (_chanceToSpawnMinValue / 100f) ? _minValue : _maxValue;
        }

        public int GenerateNext(int number)
        {
            return number * 2;
        }

        public int GetIndex(int number)
        {
            return GetPower(number) - 1;
        }

        public int GetNextPower(int number)
        {
            return GetPower(number) + 1;
        }

        public int GetPower(int number)
        {
            return (int)Mathf.Log(number, 2);
        }

        public int GetNumber(int power)
        {
            return (int)Mathf.Pow(2, power);
        }
    }
}