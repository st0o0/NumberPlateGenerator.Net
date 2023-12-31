using System;

namespace NumberPlateGenerator.Net.Core
{
    [Flags]
    public enum Countries
    {
        Unknown = 0,

        A = 1 << 0,
        AFG = 1 << 1,
        AL = 1 << 2,
        AND = 1 << 3,
        AM = 1 << 4,
        AUS = 1 << 5,
        AZ = 1 << 6,
        B = 1 << 7,
        BD = 1 << 8,
        BDS = 1 << 9,
        BF = 1 << 10,
        BG = 1 << 11,
        BH = 1 << 12,
        BIH = 1 << 13,
        BOL = 1 << 14,
        BR = 1 << 15,
        BRN = 1 << 16,
        BRU = 1 << 17,
        BS = 1 << 18,
        BUR = 1 << 19,
        BW = 1 << 20,
        BY = 1 << 21,
        CAM = 1 << 22,
        CDN = 1 << 23,
        CGO = 1 << 24,
        CH = 1 << 25,
        CI = 1 << 26,
        CL = 1 << 27,
        CO = 1 << 28,
        CR = 1 << 29,
        CU = 1 << 30,
        CY = 1 << 31,
        CZ = 1 << 32,
        D = 1 << 33,
        DK = 1 << 34,
        DY = 1 << 35,
        DZ = 1 << 36,
        E = 1 << 37,
        EAK = 1 << 38,
        EAT = 1 << 39,
        EAU = 1 << 40,
        EAZ = 1 << 41,
        EC = 1 << 42,
        ER = 1 << 43,
        ES = 1 << 44,
        EST = 1 << 45,
        ET = 1 << 46,
        ETH = 1 << 47,
        F = 1 << 48,
        FIN = 1 << 49,
        FJI = 1 << 50,
        FL = 1 << 51,
        FO = 1 << 51,
        G = 1 << 52,
        GBA = 1 << 53,
        GBG = 1 << 54,
        GBJ = 1 << 55,
        GBM = 1 << 56,
        GBZ = 1 << 57,
        GCA = 1 << 58,
        GE = 1 << 59,
        GH = 1 << 60,
        GR = 1 << 61,
        GUY = 1 << 62,
        H = 1 << 63,
        HKJ = 1 << 64,
        HN = 1 << 65,
        HR = 1 << 66,
        I = 1 << 67,
        IL = 1 << 68,
        IND = 1 << 69,
        IR = 1 << 70,
        IRL = 1 << 71,
        IRQ = 1 << 72,
        IS = 1 << 73,
        J = 1 << 74,
        JA = 1 << 75,
        K = 1 << 76,
        KG = 1 << 77,
        KSA = 1 << 78,
        KWT = 1 << 79,
        KZ = 1 << 80,
        L = 1 << 81,
        LAO = 1 << 82,
        LAR = 1 << 83,
        LB = 1 << 84,
        LS = 1 << 85,
        LT = 1 << 86,
        LV = 1 << 87,
        M = 1 << 88,
        MA = 1 << 89,
        MAL = 1 << 90,
        MC = 1 << 91,
        MD = 1 << 92,
        MEX = 1 << 93,
        MNE = 1 << 94,
        MGL = 1 << 95,
        MOC = 1 << 96,
        MS = 1 << 97,
        MV = 1 << 98,
        MW = 1 << 99,
        N = 1 << 100,
        NAM = 1 << 101,
        NAU = 1 << 102,
        NEP = 1 << 103,
        NIC = 1 << 104,
        NL = 1 << 105,
        NMK = 1 << 106,
        NZ = 1 << 107,
        OM = 1 << 108,
        P = 1 << 109,
        PA = 1 << 110,
        PE = 1 << 111,
        PK = 1 << 112,
        PL = 1 << 113,
        PNG = 1 << 114,
        PY = 1 << 115,
        Q = 1 << 116,
        RA = 1 << 117,
        RC = 1 << 118,
        RCA = 1 << 119,
        RCB = 1 << 120,
        RCH = 1 << 121,
        RG = 1 << 122,
        RH = 1 << 123,
        RI = 1 << 124,
        RIM = 1 << 125,
        RKS = 1 << 126,
        RL = 1 << 127,
        RM = 1 << 128,
        RMM = 1 << 129,
        RN = 1 << 130,
        RO = 1 << 131,
        ROK = 1 << 132,
        RP = 1 << 133,
        RSM = 1 << 134,
        RU = 1 << 135,
        RUS = 1 << 136,
        RWA = 1 << 137,
        S = 1 << 138,
        SD = 1 << 139,
        SGP = 1 << 140,
        SK = 1 << 141,
        SLO = 1 << 142,
        SME = 1 << 143,
        SN = 1 << 144,
        SO = 1 << 145,
        SRB = 1 << 146,
        SUD = 1 << 147,
        SY = 1 << 148,
        SYR = 1 << 149,
        T = 1 << 150,
        TCH = 1 << 151,
        TG = 1 << 152,
        TJ = 1 << 153,
        TM = 1 << 154,
        TN = 1 << 155,
        TO = 1 << 156,
        TR = 1 << 157,
        TT = 1 << 158,
        UA = 1 << 159,
        UAE = 1 << 160,
        UK = 1 << 161,
        USA = 1 << 162,
        UY = 1 << 163,
        UZ = 1 << 164,
        V = 1 << 165,
        VN = 1 << 166,
        WAG = 1 << 167,
        WAL = 1 << 168,
        WAN = 1 << 169,
        WD = 1 << 170,
        WG = 1 << 171,
        WL = 1 << 172,
        WS = 1 << 173,
        WV = 1 << 174,
        YAR = 1 << 175,
        YV = 1 << 176,
        Z = 1 << 177,
        ZA = 1 << 178,
        ZW = 1 << 179,

        EU = B | BG | DK | D | EST | FIN | F | GR | IRL | I | HR | LV | LT | L | M | NL | A | PL | P | RO | S | SK | SLO | E | CZ | H | CY

    }
}
