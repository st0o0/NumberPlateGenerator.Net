using System;
using System.Numerics;

namespace NumberPlateGenerator.Net.Core
{
    [Flags]
    public enum Countries : long
    {


        Unknown = 0L,

        A = 1L << 0,
        AFG = 1L << 1,
        AL = 1L << 2,
        AND = 1L << 3,
        AM = 1L << 4,
        AUS = 1L << 5,
        AZ = 1L << 6,
        B = 1L << 7,
        BD = 1L << 8,
        BDS = 1L << 9,
        BF = 1L << 10,
        BG = 1L << 11,
        BH = 1L << 12,
        BIH = 1L << 13,
        BOL = 1L << 14,
        BR = 1L << 15,
        BRN = 1L << 16,
        BRU = 1L << 17,
        BS = 1L << 18,
        BUR = 1L << 19,
        BW = 1L << 20,
        BY = 1L << 21,
        CAM = 1L << 22,
        CDN = 1L << 23,
        CGO = 1L << 24,
        CH = 1L << 25,
        CI = 1L << 26,
        CL = 1L << 27,
        CO = 1L << 28,
        CR = 1L << 29,
        CU = 1L << 30,
        CY = 1L << 31,
        CZ = 1L << 32,
        D = 1L << 33,
        DK = 1L << 34,
        DY = 1L << 35,
        DZ = 1L << 36,
        E = 1L << 37,
        EAK = 1L << 38,
        EAT = 1L << 39,
        EAU = 1L << 40,
        EAZ = 1L << 41,
        EC = 1L << 42,
        ER = 1L << 43,
        ES = 1L << 44,
        EST = 1L << 45,
        ET = 1L << 46,
        ETH = 1L << 47,
        F = 1L << 48,
        FIN = 1L << 49,
        FJI = 1L << 50,
        FL = 1L << 51,
        FO = 1L << 52,
        G = 1L << 53,
        GBA = 1L << 54,
        GBG = 1L << 55,
        GBJ = 1L << 56,
        GBM = 1L << 57,
        GBZ = 1L << 58,
        GCA = 1L << 59,
        GE = 1L << 60,
        GH = 1L << 61,
        GR = 1L << 62,
        GUY = 1L << 63,
        H = 1L << 64,
        HKJ = 1L << 65,
        HN = 1L << 66,
        HR = 1L << 67,
        I = 1L << 68,
        IL = 1L << 69,
        IND = 1L << 70,
        IR = 1L << 71,
        IRL = 1L << 72,
        IRQ = 1L << 73,
        IS = 1L << 74,
        J = 1L << 75,
        JA = 1L << 76,
        K = 1L << 77,
        KG = 1L << 78,
        KSA = 1L << 79,
        KWT = 1L << 80,
        KZ = 1L << 81,
        L = 1L << 82,
        LAO = 1L << 83,
        LAR = 1L << 84,
        LB = 1L << 85,
        LS = 1L << 86,
        LT = 1L << 87,
        LV = 1L << 88,
        M = 1L << 89,
        MA = 1L << 90,
        MAL = 1L << 91,
        MC = 1L << 92,
        MD = 1L << 93,
        MEX = 1L << 94,
        MNE = 1L << 95,
        MGL = 1L << 96,
        MOC = 1L << 97,
        MS = 1L << 98,
        MV = 1L << 99,
        MW = 1L << 100,
        N = 1L << 101,
        NAM = 1L << 102,
        NAU = 1L << 103,
        NEP = 1L << 104,
        NIC = 1L << 105,
        NL = 1L << 106,
        NMK = 1L << 107,
        NZ = 1L << 108,
        OM = 1L << 109,
        P = 1L << 110,
        PA = 1L << 111,
        PE = 1L << 112,
        PK = 1L << 113,
        PL = 1L << 114,
        PNG = 1L << 115,
        PY = 1L << 116,
        Q = 1L << 117,
        RA = 1L << 118,
        RC = 1L << 119,
        RCA = 1L << 120,
        RCB = 1L << 121,
        RCH = 1L << 122,
        RG = 1L << 123,
        RH = 1L << 124,
        RI = 1L << 125,
        RIM = 1L << 126,
        RKS = 1L << 127,
        RL = 1L << 128,
        RM = 1L << 129,
        RMM = 1L << 130,
        RN = 1L << 131,
        RO = 1L << 132,
        ROK = 1L << 133,
        RP = 1L << 134,
        RSM = 1L << 135,
        RU = 1L << 136,
        RUS = 1L << 137,
        RWA = 1L << 138,
        S = 1L << 139,
        SD = 1L << 140,
        SGP = 1L << 141,
        SK = 1L << 142,
        SLO = 1L << 143,
        SME = 1L << 144,
        SN = 1L << 145,
        SO = 1L << 146,
        SRB = 1L << 147,
        SUD = 1L << 148,
        SY = 1L << 149,
        SYR = 1L << 150,
        T = 1L << 151,
        TCH = 1L << 152,
        TG = 1L << 153,
        TJ = 1L << 154,
        TM = 1L << 155,
        TN = 1L << 156,
        TO = 1L << 157,
        TR = 1L << 158,
        TT = 1L << 159,
        UA = 1L << 160,
        UAE = 1L << 161,
        UK = 1L << 162,
        USA = 1L << 163,
        UY = 1L << 164,
        UZ = 1L << 165,
        V = 1L << 166,
        VN = 1L << 167,
        WAG = 1L << 168,
        WAL = 1L << 169,
        WAN = 1L << 170,
        WD = 1L << 171,
        WG = 1L << 172,
        WL = 1L << 173,
        WS = 1L << 174,
        WV = 1L << 175,
        YAR = 1L << 176,
        YV = 1L << 177,
        Z = 1L << 178,
        ZA = 1L << 179,
        ZW = 1L << 180,
        
        EU = B | BG | DK | D | EST | FIN | F | GR | IRL | I | HR | LV | LT | L | M | NL | A | PL | P | RO | S | SK | SLO | E | CZ | H | CY | 1 << 181,
    }
}
