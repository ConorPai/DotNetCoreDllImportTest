#include "mzencryptutil_c.h"
#include "mzencryptutil.h"

using namespace Foundation;

void mzEncryptUtil_encrypt_default( char* src, int nLength )
{
	mzEncryptUtil::instance().encrypt(src, nLength);
}

void mzEncryptUtil_encrypt( char* src, int nLength, int secretcode )
{
	mzEncryptUtil::instance().encrypt(src, nLength, secretcode);
}

void mzEncryptUtil_decrypt_default( char* src, int nLength )
{
	mzEncryptUtil::instance().decrypt(src, nLength);
}

void mzEncryptUtil_decrypt( char* src, int nLength, int secretcode )
{
	mzEncryptUtil::instance().decrypt(src, nLength, secretcode);
}