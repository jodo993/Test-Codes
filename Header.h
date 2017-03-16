#pragma once

template <typename T>
class PairOf
{
public:
	T one;
	T other;
	T WhichIsBigger(T one, T other)
	{
		if (one > other)
			return one;
		return other;
	}
};