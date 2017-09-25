#ifndef MZ_ENTRYPT_UTIL_H
#define MZ_ENTRYPT_UTIL_H

namespace Foundation
{
	class mzEncryptUtil
	{
	public:
		mzEncryptUtil();
		~mzEncryptUtil();

		static mzEncryptUtil& instance();

		void encrypt(char* src, int nLength);
		void encrypt(char* src, int nLength, int secretcode);
		void decrypt(char* src, int nLength);
		void decrypt(char* src, int nLength, int secretcode);

	private:

		char* m_cKeyArray;
		int m_nKeyArrayLength;
	};
}

#endif