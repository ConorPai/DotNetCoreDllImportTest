#include "mzencryptutil.h"

using namespace Foundation;

mzEncryptUtil::mzEncryptUtil()
{
	m_cKeyArray = new char[1024]();
	m_cKeyArray = "UaMiyfRVrS24s9AHl34MyYeUgWU8PxknMf8WCmarvWh5SdAHbaKL2B0652bLvTf4HOsmaOe82MrMR"
				  "jbcwm6PXJukpc0Klz6LQnxdUnGw5LSqkoW08piWAg8ui78XEXDQP5DV7riQJTl0eabXeTmjYqgzTMq"
				  "IBXoKEsVb3QgBnR4hph5lTULt10PxvoO1iaryMEFTcd0FdwLIlrDFuwZQm4SOMyPOcptmzGFVMmiQ4"
				  "gqFphleUjGVlLmRW1gNxlDXdzjPVS2iojVfNnzFmK42SHaYuX9VgEsTNDBZ7GsbryHcZgeJBLBWqKe"
				  "Gyu7ThbT0cCkVJHQr2Lua89oTAtEdFCcy5ANlvsjwYmWN3X2eVFy9UGAvgntXGPuKAV0j4E6KB7lWm"
				  "KZMBAsaecNz9rfh9wZi1lni7TkrIXIXuOjFyQwgxuGxiAjMyZLfhc4bxRPSqbCqE0evhKTs9TVHOZ9"
				  "GJH2SmDPrThiQaOZv1q3rvYEYgsfyqxwIRjiTiTdakWLaCdsv3zPy5SkVceM4yrbwVJ81Fgnim3gJm"
				  "EwdaTE0S8M9wRegjM3Vpo2eAZXmGlcLJHRJ3OXkNW782jyibcqnX7qE8J4QOlWJxXkwHq8gLB4fIQz"
				  "dFiWyXLqnLtTgGCaxKEwoWEWrglvYJ2borKPNX9Jl3i6oafjBHFdtkrbwErMqCOSsFY5WwJL4luNH0"
				  "dgmxcx74gsOrtS75BEnNSljxf73ji0NDGAkFdfMvuLRNheq36q3jumu57ZrfDYVqOkU2HC1w2thDGp"
				  "aRam27EjugoIoXG2GZB86uxvEyGrC3mCBJryCL3tkbAWs4MJvaWscHsQtPSDAmRB3WhPFiz46hY53K"
				  "cJW76Cg4A3qLeX2z27u93FX7dmK1w4TxWTMiRDqpu8wny4eLbGp0L3RGWY3U1oIFj3YulUSzQfP4jJ"
				  "jh9ZO2W2cfw2JFxfA0dEfUArYZjGoWxmpUN2zS0rh6sfxZlRJDsFedwIHbZSqNpRjMZ2FQS9WxjCu4"
				  "898YPtfRlRq";
	m_nKeyArrayLength = 1024;
}

mzEncryptUtil::~mzEncryptUtil()
{
	if (m_cKeyArray != 0)
	{
		delete[] m_cKeyArray;
		m_cKeyArray = 0;
	}
}

mzEncryptUtil& mzEncryptUtil::instance()
{
	static Foundation::mzEncryptUtil __instance;
	return __instance;
}

void mzEncryptUtil::encrypt( char* src, int nLength )
{
	return encrypt(src, nLength, 0);
}

void mzEncryptUtil::encrypt( char* src, int nLength, int secretcode )
{
	for (int i = 0; i < nLength; i++)
	{
		char cSrc = src[i];

		char cKey = i + secretcode > m_nKeyArrayLength - 1 ? m_cKeyArray[i + secretcode - m_nKeyArrayLength] : m_cKeyArray[i + secretcode];
		src[i] = cSrc ^ cKey;
	}
}

void mzEncryptUtil::decrypt( char* src, int nLength )
{
	return encrypt(src, nLength, 0);
}

void mzEncryptUtil::decrypt( char* src, int nLength, int secretcode )
{
	return encrypt(src, nLength, secretcode);
}