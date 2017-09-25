#pragma once

extern "C"
{
	void mzEncryptUtil_encrypt_default(char* src, int nLength);
	void mzEncryptUtil_encrypt(char* src, int nLength, int secretcode);
	void mzEncryptUtil_decrypt_default(char* src, int nLength);
	void mzEncryptUtil_decrypt(char* src, int nLength, int secretcode);
};
